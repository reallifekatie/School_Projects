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
 <!--To do: Import materialize.css-->
<link type="text/css" rel="stylesheet" href="css/materialize.css" media="screen,projection"/>
  
</head>
    
<?php include("./includes/header.php"); ?>

<!--To do: Require functions.php -->
<?php require("./includes/functions.php"); ?> 
    
<body>
<?php 
     
    $pets= array();
    if ($_SERVER["REQUEST_METHOD"] == "POST") {
        
        $petName = $_POST['petName'];
        $imageFile = $_POST['imageFile'];
        $ownerFname = $_POST['ownerFname'];
        $ownerLname = $_POST['ownerLname'];
        $email = $_POST['email'];
        $cell = $_POST['cell'];
        $allergies = $_POST['allergies'];
        $aggressive = $_POST['aggressive'];
        
        $pets = [  
            ['imageName'=>$imageFile, 'customerID'=>'1', 'petName'=>$petName, 'activeRow'=>'NO', 'ownerFirstName'=>$ownerFname, 'ownerLastName'=>$ownerLname, 
            'email'=>$email, 'cell'=>$cell, 'Allergies'=>$allergies, 'Aggressive'=>$aggressive]
        ];
        array_push($pets);
                
        //if
        // use array_push to add pet to the array , get values from the post global 
        // an example of one element is 'imageName' => "{$_POST['imageName']}"
        
    } else {
        // default pet list
        $pets =[ 
        
        ['imageName' => 'mouse.png', 'customerID' => '1', 'petName' => 'minnie', 'activeRow' => 'NO', 'ownerFirstName' => 'Sally', 'ownerLastName' => 'Jones', 'email' => 'owner@gmail.com', 'cell' => '336-555-1212', 'Allergies' => 'N', 'Aggressive' => 'N'],
        
        ['imageName' => 'aligator.png', 'customerID' => '2', 'petName' => 'alfred', 'activeRow' => 'NO', 'ownerFirstName' => 'Sally', 'ownerLastName' => 'Jones', 'email' => 'owner@gmail.com', 'cell' => '336-555-1212', 'Allergies' => 'N', 'Aggressive' => 'Y']
    ];
    }  
?>
<!-- First Grid -->
<div class="w3-row-padding w3-padding-64 w3-container">
  <div class="w3-content">
    <div class="w3-twothird">
      <h1>Unit Four</h1>
        <section>
            <?php echo displayRow($pets); ?>
        </section>
        <section class="container grey-text">
		<h4 class="center">Add a Pet</h4>
		<form class="white" action="" method="POST">
            
            <label for="petName">Pet Name</label>
                <input type="text" id="petName" name="petName">
            <label for="imageFile">Image File Name</label>
                <input type="text" id="imageFile" name="imageFile">
            <label for="ownerFname">Owner First Name</label>
                <input type="text" id="ownerFname" name="ownerFname">
            <label for="ownerLname">Owner Last Name</label>
                <input type="text" id="ownerLname" name="ownerLname">
            <label for="email">Email</label>
                <input type="text" id="email" name="email">
            <label for="cell">Cell</label>
                <input type="number" id="cell" name="cell">
            <label for="allergies">Allergies</label>
                <input type="text" id="allergies" name="allergies">
            <label for="aggressive">Aggressive</label>
                <input type="text" id="aggressive" name="aggressive">
            <div class="center">
                <input type="submit" value="Submit" class="btn brand z-depth-0">
            </div>
                
		</form>
	</section>
  </div>
    </div>
  </div>
 
<div class="w3-container w3-black w3-center w3-opacity w3-padding-64">
    <h1 class="w3-margin w3-xlarge">Quote of the day: live life</h1>
</div>

<!-- Footer -->
<?php include("./includes/footer.php"); ?>

</body>
</html>

