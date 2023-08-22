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
 <style>
    .styled-table {
        border-collapse: collapse;
        margin: 25px 0;
        font-size: 0.9em;
        font-family: sans-serif;
        min-width: 600px;
        box-shadow: 0 0 20px rgba(0, 0, 0, 0.15);
    } 
    .styled-table thead tr {
    background-color: #f54242;
    color: #ffffff;
    text-align: left;
        
    }
    .styled-table th,
    .styled-table td {
    padding: 12px 15px;
    }
    .styled-table tbody tr {
    border-bottom: 1px solid #dddddd;
    }

    .styled-table tbody tr:nth-of-type(even) {
    background-color: #f3f3f3;
    }

    .styled-table tbody tr:last-of-type {
    border-bottom: 2px solid #f54242;
    }
    .styled-table tbody tr.active-row {
    font-weight: bold;
    color: #f54242;
    }
</style>
</head>

    <div>test</div>
    
<?php include("./includes/header.php");
    
// create an array of pet data...    
$pets = [ 
    ['imageName'=>'mouse.png', 'customerID'=>'1', 'petName'=>'Mickey', 'ownerLname'=>'Bundy', 'ownerFname'=>'Ted', 'ownerEmail'=>'ted@yahoo.com', 'ownerPhone'=>'336-867-5309', 'allergies'=>'N', 'aggressive'=>'Y', 'activeRow'=>'NO'],
    ['imageName'=>'bluebird.png', 'customerID'=>'2', 'petName'=>'Bluey', 'ownerLname'=>'Gacy', 'ownerFname'=>'John Wayne', 'ownerEmail'=>'john@yahoo.com', 'ownerPhone'=>'704-867-5309', 'allergies'=>'N', 'aggressive'=>'N', 'activeRow'=>'NO'],
    ['imageName'=>'aligator.png', 'customerID'=>'3', 'petName'=>'Allie', 'ownerLname'=>'Fish', 'ownerFname'=>'Albert', 'ownerEmail'=>'albert@yahoo.com', 'ownerPhone'=>'919-867-5309', 'allergies'=>'N', 'aggressive'=>'Y', 'activeRow'=>'NO'],
    ['imageName'=>'chicken.png', 'customerID'=>'4', 'petName'=>'Dinner', 'ownerLname'=>'Dahmer', 'ownerFname'=>'Jeffrey', 'ownerEmail'=>'jeffrey@yahoo.com', 'ownerPhone'=>'910-867-5309', 'allergies'=>'Y', 'aggressive'=>'N', 'activeRow'=>'NO'],
    ['imageName'=>'crab.png', 'customerID'=>'5', 'petName'=>'Mr Crabs', 'ownerLname'=>'Shipman', 'ownerFname'=>'Harold', 'ownerEmail'=>'harold@yahoo.com', 'ownerPhone'=>'980-867-5309', 'allergies'=>'N', 'aggressive'=>'N', 'activeRow'=>'NO'],
    ['imageName'=>'walrus.png', 'customerID'=>'6', 'petName'=>'Wallie', 'ownerLname'=>'Ramirez', 'ownerFname'=>'Richard', 'ownerEmail'=>'richard@yahoo.com', 'ownerPhone'=>'212-867-5309', 'allergies'=>'N', 'aggressive'=>'N', 'activeRow'=>'NO'],
    ['imageName'=>'cow.png', 'customerID'=>'7', 'petName'=>'Moomoo', 'ownerLname'=>'Whitman', 'ownerFname'=>'Charles', 'ownerEmail'=>'chuck@yahoo.com', 'ownerPhone'=>'512-867-5309', 'allergies'=>'Y', 'aggressive'=>'N', 'activeRow'=>'NO'],
    ['imageName'=>'octopus.png', 'customerID'=>'8', 'petName'=>'Calimari', 'ownerLname'=>'Duntsch', 'ownerFname'=>'Christopher', 'ownerEmail'=>'chris@yahoo.com', 'ownerPhone'=>'615-867-5309', 'allergies'=>'N', 'aggressive'=>'N', 'activeRow'=>'NO'],
    ['imageName'=>'vulture.png', 'customerID'=>'9', 'petName'=>'Voldemort', 'ownerLname'=>'Rudolph', 'ownerFname'=>'Eric', 'ownerEmail'=>'eric@yahoo.com', 'ownerPhone'=>'828-867-5309', 'allergies'=>'N', 'aggressive'=>'N', 'activeRow'=>'NO'],
    ['imageName'=>'sloth.png', 'customerID'=>'10', 'petName'=>'Speedy', 'ownerLname'=>'Wuornos', 'ownerFname'=>'Aileen', 'ownerEmail'=>'aileen@yahoo.com', 'ownerPhone'=>'850-867-5309', 'allergies'=>'N', 'aggressive'=>'Y', 'activeRow'=>'NO']
];
    
 //function to remove all active rows, you can use this or not   
function removeActiveRow() {
    $rows = 0;
    global $pets;
    foreach ($pets as $pet) {
        $rows += 1;
    }
    for ($r=0; $r<$rows; $r++) {
        $pets[$r]['activeRow'] = 'NO';
    }
}

// create a function to display a row of data, be sure to return the string vs echo it in the function

function displayRow($pets) {
    $row = "";
    foreach ($pets as $pet) {
        if ($pet['activeRow'] == 'YES') {
            $row .= "<tr class='active-row'>";
            
        } else {
            $row .= "<tr>";
        } 
        
        $row .= "<td><img src='images/{$pet['imageName']}' height='50px' /></td>";
        $row .= "<td>{$pet['customerID']}";
        $row .= "<td>{$pet['petName']}";
        $row .= "<td>{$pet['ownerLname']}";
        $row .= "<td>{$pet['ownerFname']}";
        $row .= "<td>{$pet['ownerEmail']}";
        $row .= "<td>{$pet['ownerPhone']}";
        $row .= "<td>{$pet['allergies']}";
        $row .= "<td>{$pet['aggressive']}";
        $row .= "</tr>";    
        
    }
    return $row;
}
    
?> 
      
<body>
<?php
        if ($_SERVER["REQUEST_METHOD"] == "POST") {
            
            // var_dump($_POST);
            $activeID = $_POST['customerID'];
            global $pets;
            $row = 0;
            foreach ($pets as $pet) {
                if ($pet['customerID'] == $activeID) {
                    removeActiveRow($pets);
                    $pets[$row]['activeRow'] = 'YES';
                    // print_r($pet);
                }
                $row += 1;
            }
            
        }       
?>
     
<!-- First Grid -->
<div class="w3-row-padding w3-padding-64 w3-container">
  <div class="w3-content">
    <div class="w3-twothird">
      <h1>Unit Three</h1>
    </div>
  </div>
</div>
    
<div class="w3-content">
    <table class="styled-table">
     <thead>
          <tr>
            <th>Picture</th>
            <th>Customer ID</th>
            <th>Pet Name</th>
            <th>Owner Last Name</th>
            <th>Owner First Name</th>
            <th>Owner Email</th>
            <th>Owner Cell/Phone</th>
            <th>Allergies? Y/N</th>
            <th>Aggressive? Y/N</th>
          </tr>
        </thead>
        <tbody>
            <?php
            echo displayRow($pets);
            ?>
        </tbody>
</table>
    <form action="" method="POST">
        <label for="customerID">Choose Pet to Highlight: </label>
        <input type="text" id="customerID" name="customerID" placeholder="Enter Customer ID"><br><br>
        <input type="submit" value="Submit"><hr>
    </form>
</div>

   

<!-- Footer -->
<?php include("./includes/footer.php"); ?>

</body>
</html>

