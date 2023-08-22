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
        
        $petName = htmlspecialchars($_POST['petName']);
        $imageFile = htmlspecialchars($_POST['imageFile']);
        $ownerFname = htmlspecialchars($_POST['ownerFname']);
        $ownerLname = htmlspecialchars($_POST['ownerLname']);
        $email = htmlspecialchars($_POST['email']);
        $cell = htmlspecialchars($_POST['cell']);
        $allergies = htmlspecialchars($_POST['allergies']);
        $aggressive = htmlspecialchars($_POST['aggressive']);
        
        $errorText = '<section class="container red-text"><h4> Errors! </h4>';
        $isError = false;
                
        if (empty($_POST['petName'])) {
            $isError = true;
            $errorText .= "<p>The Pet Name field cannot be blank.</p>";
        }
        if (!preg_match('/^[a-zA-Z\s]=$/', $ownerFname)) {
            echo "Owner's First Name must contain letters and spaces only.";
        }
        if (empty($_POST['ownerLname'])) {
            $isError = true;
            $errorText .= "<p>The Owner's Last Name field cannot be blank.</p>";
        }
        if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
            $isError = true;
            $errorText .= "<p>The Email field must contain a valid email address.</p>";
        }
        if (!strpos($_POST['cell'], "-")) {
            $isError = true;
            $errorText .= "<p>The Cell field must contain at least one dash.</p>";
        }
        if ($allergies != 'Y' or $allergies !== 'y' or $allergies !== 'N' or $allergies !== 'n') {
            $isError = true;
            $errorText .= "<p>Please enter Y, y, N, or n in the Allergies field.</p>";
        }
        
        $errorText .= "</section>";
    
        if ($isError) {
            echo $errorText;
        }    
        
        $pets = [  
            ['imageName' => $imageFile, 'customerID' => '1', 'petName' => $petName, 'activeRow' => 'NO', 'ownerFirstName' => $ownerFname, 'ownerLastName' => $ownerLname, 'email' => $email, 'cell' => $cell, 'Allergies' => $allergies, 'Aggressive' => $aggressive]
        ];
        array_push($pets);
        
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
      <h1>Unit Five</h1>
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
                <input type="tel" id="cell" name="cell">
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

