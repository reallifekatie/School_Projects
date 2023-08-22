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
<a href="index.php" class="w3-bar-item w3-button w3-padding-large w3-white">Home</a>
</head>
    
<?php include("./includes/header.php"); ?>
    
<body>

<?php
    
    // add array of food... 
    // name, title/caption , description, image name 
    $foodItems = [
        ['name'=>'sandwich', 'title'=>'The Perfect Sandwich, A Real NYC Classic', 'description'=>'You can\'t handle this sandwich!', 'imageName'=>'images/sandwich.png'],
        ['name'=>'steak', 'title'=>'Let Me Tell You About This Steak', 'description'=>'Try your best NOT to lick your computer screen.', 'imageName'=>'images/steak.png'],
        ['name'=>'cherries', 'title'=>'Cherries, Interrupted', 'description'=>'These cherries are good enough to be topped with a cherry.', 'imageName'=>'images/cherries.png'],
        ['name'=>'pasta', 'title'=>'Once Again, Robust Wine & Vegetable', 'description'=>'Bring a date to recreate Lady and the Tramp pasta scene.', 'imageName'=>'images/pasta.png'],
        ['name'=>'popsicle', 'title'=>'All I Need Is A Popsicle', 'description'=>'I scream, you scream, we all scream for popsicles!', 'imageName'=>'images/popsicle.png'],
        ['name'=>'sandwich2', 'title'=>'The Perfect Sandwich, A Real Greensboro Classic', 'description'=>'Voted Best Sandwich in Greensboro!', 'imageName'=>'images/sandwich2.png'],
        ['name'=>'french', 'title'=>'Le French', 'description'=>'It has that certain, je ne sais pas.', 'imageName'=>'images/french.png']        
    ];
          
 ?> 

<!-- First Grid -->
<div class="w3-row-padding w3-padding-64 w3-container">
  <div class="w3-content">
    <div class="w3-twothird">
      <h1>Unit Two</h1>
    </div>
  </div>
</div>
 
<div class="w3-main w3-content w3-padding" style="max-width:1200px;margin-top:100px">

    <?php

    // display array information ...
    
    echo '<div class="w3-row-padding w3-padding-16 w3-center" id="food">';
    
     // display items 0,1,2,3...
    for ($i=0; $i<4; $i++) {
        echo '<div class="w3-quarter">';
        echo '<img src="' . $foodItems[$i]['imageName'] . '" alt="' . $foodItems[$i]['name'] .'" style="width:100%">';
        echo '<h3>' . $foodItems[$i]['title'] . '</h3>';
        echo '<p>' . $foodItems[$i]['description'] . '</p>';
        echo '</div>';
    }  
    
     
    echo '<div class="w3-row-padding w3-padding-16 w3-center">';
    
    // display items 4,5,6,7...
    for ($i=4; $i<7; $i++) {
        echo '<div class="w3-quarter">';
        echo '<img src="' . $foodItems[$i]['imageName'] . '" alt="' . $foodItems[$i]['name'] .'" style="width:100%">';
        echo '<h3>' . $foodItems[$i]['title'] . '</h3>';
        echo '<p>' . $foodItems[$i]['description'] . '</p>';
        echo '</div>';
    }    
   
    ?>
  </div>
    
<!-- Footer -->
<?php include("./includes/footer.php"); ?>

</body>
</html>

