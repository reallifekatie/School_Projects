<!DOCTYPE html>
<html lang="en">
<head>
<title>WEB 182</title>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Lato">
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Montserrat">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"> 
<link rel="stylesheet" href="./css/sitecss.css">   
 
</head>
 
<?php 

    if(!isset($_SESSION)) {
        session_start();
    } else {
        
    }
    
    //if (isset($_POST['submit'])) {
    if ($_SERVER['REQUEST_METHOD'] == "POST") {
        $_SESSION['firstName'] = $_POST['firstName'];
        $_SESSION['lastName'] = $_POST['lastName'];
    } else {
        $_SESSION['firstName'] = "";
        $_SESSION['lastName'] = "";
    }
    include("./includes/header.php"); 
    var_dump($_POST);
    echo "<br><br>";
    var_dump($_SESSION);
?>
    
<body>

<div class="w3-row-padding w3-padding-64 w3-container">
  <div class="w3-content">
    <div class="w3-twothird">
        <h1>WEB 182 Website - Home</h1>
        <h1>Katie Smith</h1>
        <h5 class="w3-padding-32">Welcome to your WEB 182 Website! Each Unit we will add to this site as we learn new concepts in PHP. </h5>
        
        <form action="" method="POST">
            <label>First Name: </label>
                <input type='text' name='firstName'><br><br>
            <label>Last Name: </label>
                <input type='text' name='lastName'><br><br>
            <input type='submit' name='submit' value='Submit'>
        </form>
    
      <p class="w3-text-grey">Baseball ipsum dolor sit amet passed ball outs, sweep stretch bleeder triple play. Left fielder count fair swing cork balk ball. Full count southpaw reliever lineup crooked number fastball second base. Perfect game outfielder rally force dodgers right fielder dead ball era right field. Pickoff world series peanuts batting average cup of coffee foul inside robbed. Bleeder club appeal first base sidearm mustard steal line drive inning.</p>
    </div>

    <div class="w3-third w3-center">
      <i class="fa fa-anchor w3-padding-64 w3-text-red"></i>
    </div>
  </div>
</div>

<div class="w3-row-padding w3-light-grey w3-padding-64 w3-container">
  <div class="w3-content">
    <div class="w3-third w3-center">
      <i class="fa fa-coffee w3-padding-64 w3-text-red w3-margin-right"></i>
    </div>

    <div class="w3-twothird">
      <h1>Lorem Ipsum</h1>
      <h5 class="w3-padding-32">Sidearm bullpen base on balls national pastime losses reliever umpire pull dribbler. Manager 4-bagger tag national pastime pennant good eye relief pitcher. Save on-base percentage fan ejection baseball card skipper reliever strikeout bench. On-base percentage fenway contact win warning track, ball rhubarb center field. Starting pitcher hey batter out cellar cardinals basehit double switch. Play hey batter tigers sidearm in the hole shortstop no decision.</h5>

      <p class="w3-text-grey">Off-speed petey pinch hitter astroturf walk off no decision count full count wrigley. Hack cheese helmet tossed gap run red sox. Fall classic in the hole ejection rotation rally center field shift. Manager pickoff knuckleball assist pinch runner pitchout stretch. Steal hardball extra innings alley rubber off-speed flyout third base. Baseline butcher boy umpire left field hitter, catcher win right field can of corn.</p>
    </div>
  </div>
</div>

<div class="w3-container w3-black w3-center w3-opacity w3-padding-64">
    <h1 class="w3-margin w3-xlarge">Quote of the day: live life</h1>
</div>

<?php include("./includes/footer.php"); ?>

</body>
</html>

