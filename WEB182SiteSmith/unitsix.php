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

<link type="text/css" rel="stylesheet" href="css/materialize.css" media="screen,projection"/>
  
</head>
    
<?php include("./includes/header.php"); ?>

<?php require("./includes/functions.php"); ?> 
     
<body>
<?php 
    
    $pets= array();
    
    $errorsArray = array();
    $errorsArray['petName'] = "";
    $errorsArray['imageName'] = "";
    $errorsArray['ownerFirstName'] = "";
    $errorsArray['ownerLastName'] = "";
    $errorsArray['email'] = "";
    $errorsArray['cell'] = "";
    $errorsArray['allergies'] = "";
    $errorsArray['aggressive'] = "";
    
    if ($_SERVER["REQUEST_METHOD"] == "POST") {
        
        $pets = $_SESSION['petData'];
            
        $customerID = strval(count($pets) + 1);
        $isError = false;
             
        if (empty($_POST['imageName'])) {
            $isError = true;
            $errorsArray['imageName'] = 'Image File Name cannot be blank.';
        } else {
            if (strpos($_POST['imageName'], ".png")) {
                $imageName = htmlspecialchars($_POST['imageName']);
            } else {
                $isError = true;
                $errorsArray['imageName'] = 'Image File Name must have a .png extension.';
            }
        }
        if (empty($_POST['petName'])) {
            $isError = true;
            $errorsArray['petName'] = 'Pet Name cannot be blank.';
        } else {
            $petName = htmlspecialchars($_POST['petName']);
        }
        if (empty($_POST['ownerFirstName'])) {
            $isError = true;
            $errorsArray['ownerFirstName'] = 'Owner First Name cannot be blank.';
        } else {
            $ownerFirstName = htmlspecialchars($_POST['ownerFirstName']);
        }
        if (empty($_POST['ownerLastName'])) {
            $isError = true;
            $errorsArray['ownerLastName'] = 'Owner Last Name cannot be blank.';
        } else {
            $ownerLastName = htmlspecialchars($_POST['ownerLastName']);
        }
        if (!filter_var($_POST['email'], FILTER_VALIDATE_EMAIL)) {
            $isError = true;
            $errorsArray['email'] = 'Please enter a valid email address.';
        } else {
            $email = htmlspecialchars($_POST['email']);
        }
        if (!strpos($_POST['cell'], "-")) {
            $isError = true;
            $errorsArray['cell'] = 'Cell number must contain at least one dash.';
        } else {
            $cell = htmlspecialchars($_POST['cell']);
        }
        if ($_POST['allergies'] == "Y" || $_POST['allergies'] == "y" || $_POST['allergies'] == "N" || $_POST['allergies'] == "n") {
            $allergies = htmlspecialchars($_POST['allergies']);
        } else {
            $allergies = htmlspecialchars($_POST['allergies']);
            $isError = true;
            $errorsArray['allergies'] = 'Please enter Y, N, y, or n in the Allergies field.';
        }
        $aggressive = htmlspecialchars($_POST['aggressive']);
            
        $newPet = array('imageName' => $imageName, 'customerID' => $customerID, 'petName' => $petName, 'activeRow' => 'NO', 'ownerFirstName' => $ownerFirstName, 'ownerLastName' => $ownerLastName, 'email' => $email, 'cell' => $cell, 'Allergies' => $allergies, 'Aggressive' => $aggressive);
            
        array_push($pets, $newPet);
            
        $_SESSION['petData'] = $pets;
            
    } else {
        
        $pets =[ 
        
        ['imageName' => 'mouse.png', 'customerID' => '1', 'petName' => 'minnie', 'activeRow' => 'NO', 'ownerFirstName' => 'Sally', 'ownerLastName' => 'Jones', 'email' => 'owner@gmail.com', 'cell' => '336-555-1212', 'Allergies' => 'N', 'Aggressive' => 'N'],
        
        ['imageName' => 'aligator.png', 'customerID' => '2', 'petName' => 'alfred', 'activeRow' => 'NO', 'ownerFirstName' => 'Sally', 'ownerLastName' => 'Jones', 'email' => 'owner@gmail.com', 'cell' => '336-555-1212', 'Allergies' => 'N', 'Aggressive' => 'Y']
   
        ];
        $_SESSION['petData'] = $pets;
    }  
?>

<div class="w3-row-padding w3-padding-64 w3-container">
  <div class="w3-content">
    <div class="w3-twothird">
      <h1>Unit Six</h1>
        <section>
            <?php echo displayRow($pets); ?>
        </section>
        <section class="container grey-text">
		<h4 class="center">Add a Pet</h4>
		<form class="white" action="" method="POST">
            
            <div class="red-text"><?php echo $errorsArray['petName'] ?></div>
            <label for="petName">Pet Name</label>
                <input type="text" name="petName" value="<?php $petName ?>">
            
            <div class="red-text"><?php echo $errorsArray['imageName'] ?></div>
            <label for="imageName">Image File Name</label>
                <input type="text" name="imageName" value="<?php $imageName ?>">
            
            <div class="red-text"><?php echo $errorsArray['ownerFirstName'] ?></div>
            <label for="ownerFirstName">Owner First Name</label>
                <input type="text" name="ownerFirstName" value="<?php $ownerFirstName ?>">
            
            <div class="red-text"><?php echo $errorsArray['ownerLastName'] ?></div>
            <label for="ownerLastName">Owner Last Name</label>
                <input type="text" name="ownerLastName" value="<?php $ownerLastName ?>">
            
            <div class="red-text"><?php echo $errorsArray['email'] ?></div>
            <label for="email">Email</label>
                <input type="text" name="email" value="<?php $email ?>">
            
            <div class="red-text"><?php echo $errorsArray['cell'] ?></div>
            <label for="cell">Cell</label>
                <input type="tel" name="cell" value="<?php $cell ?>">
            
            <div class="red-text"><?php echo $errorsArray['allergies'] ?></div>
            <label for="allergies">Allergies</label>
                <input type="text" name="allergies" value="<?php $allergies ?>">
            
            <label for="aggressive">Aggressive</label>
                <input type="text" name="aggressive" value="<?php $aggressive ?>">
            
            <div class="center">
                <input type="submit" value="Submit" class="btn brand z-depth-0">
            </div>
		</form>
	</section>
  </div>
    </div>
  </div>
 
<div class="w3-container w3-black w3-center w3-opacity w3-padding-64">
    <h1 class="w3-margin w3-xlarge">Quote of the Day:<br><br>"If you always do what you always did, <br>you'll always get what you always got." <br><br>-Henry Ford</h1>
</div>

<!-- Footer -->
<?php include("./includes/footer.php"); ?>

</body>
</html>

