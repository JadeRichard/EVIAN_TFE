// ml5.js: Pose Classification
// The Coding Train / Daniel Shiffman
// https://thecodingtrain.com/Courses/ml5-beginners-guide/7.2-pose-classification.html
// https://youtu.be/FYgYyq-xqAw

// All code: https://editor.p5js.org/codingtrain/sketches/JoZl-QRPK

// Separated into three sketches
// 1: Data Collection: https://editor.p5js.org/codingtrain/sketches/kTM0Gm-1q
// 2: Model Training: https://editor.p5js.org/codingtrain/sketches/-Ywq20rM9
// 3: Model Deployment: https://editor.p5js.org/codingtrain/sketches/c5sDNr8eM

let video;
let poseNet;
let pose;
let skeleton;

let brain;

let oscPort;
let server = {
	IP : "127.0.0.1",
	port : 6969
}


function setup() {
    oscPort = new osc.WebSocketPort({
		url: `ws://${"127.0.0.1"}:${6969}`, // URL to your Web Socket server.
		metadata: true
	});
	oscPort.on("ready", onOscReady);
	oscPort.on("close", onOscClose);
	oscPort.on("message", onMessage);
	oscPort.open();
    
  createCanvas(640, 480);
  video = createCapture(VIDEO);
  video.hide();
  poseNet = ml5.poseNet(video, modelLoaded);
  poseNet.on('pose', gotPoses);

  let options = {
    inputs: 34,
    outputs: 4,
    task: 'classification',
    debug: true
      
      
  }
  brain = ml5.neuralNetwork(options);
  const modelInfo = {
    model: 'model/model.json',
    metadata: 'model/model_meta.json',
    weights: 'model/model.weights.bin',
  };
  brain.load(modelInfo, brainLoaded);
}

function onOscReady(){
    console.log("You are connected to the web socket server");
}

function onOscClose(){
    console.log("You are disconnected");
}

function onMessage(oscMsg){
    console.log("An OSC message just arrived!");
    console.log(oscMsg.address);
    for(let arg of oscMsg.args){
        console.log(arg.value);
    }
}

function brainLoaded() {
  console.log('pose classification ready!');
  classifyPose();
}

function classifyPose() {
  if (pose) {
    let inputs = [];
    for (let i = 0; i < pose.keypoints.length; i++) {
      let x = pose.keypoints[i].position.x;
      let y = pose.keypoints[i].position.y;
      inputs.push(x);
      inputs.push(y);
    }
    brain.classify(inputs, gotResult);
  } else {
    setTimeout(classifyPose, 100);
  }
}

function gotResult (error, results){
    let value =  results[0].label;
    oscPort.send({
      address : "/position/"+value,
      args : [{
        type : getType(value),
        value : value
      }]  
    });
  
    
    console.log(results);
                                     console.log(results[0].label);
  classifyPose();
}
  




function getType(value){
    if(toString.call(value) === '[object Number]'){
        if((""+value).includes(".")){
            return "f";
        }else{
            return "i";
        }
    }
    else if(toString.call(value) === '[object String]'){
        return "s";
    }
}

function onMessage(oscMsg) {
    console.log("An OSC message just arrived!", oscMsg);
}

function gotPoses(poses) {
  if (poses.length > 0) {
    pose = poses[0].pose;
    skeleton = poses[0].skeleton;
  }
}


function modelLoaded() {
  console.log('poseNet ready');
}

function draw() {
 
  push();
  translate(video.width, 0);
  scale(-1, 1);
  image(video, 0, 0, video.width, video.height);

  if (pose) {
    for (let i = 0; i < skeleton.length; i++) {
      let a = skeleton[i][0];
      let b = skeleton[i][1];
      strokeWeight(2);
      stroke(0);

      line(a.position.x, a.position.y, b.position.x, b.position.y);
    }
    for (let i = 0; i < pose.keypoints.length; i++) {
      let x = pose.keypoints[i].position.x;
      let y = pose.keypoints[i].position.y;
      fill(0);
      stroke(255);
      ellipse(x, y, 16, 16);
    }
  }

  
}