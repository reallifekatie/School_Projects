<!DOCTYPE html>
<html>
   
<body>
 <?php include "./includes/header.php" ?>


<!-- About Container -->
<div class="w3-container w3-padding-64 w3-red w3-grayscale w3-xlarge" id="about">
  <?php
    
                $dbc = new mysqli("localhost", "katiesmith", "cnit2648", "pizza");
    
                if ($dbc->connect_error) {
                    die("Connection failed: " . $dbc->connect_error);
                }
                // add new menu item
                if (isset($_POST['add'])) {
                    $starter = $_POST['starter'];
                    $entree = $_POST['entree'];
                    $discount = $_POST['discount'];
                    
                    //$sqlUpdate = "UPDATE specials SET special_item_starter = '$starter', special_item_entree = '$entree', special_item_discount = '$discount' WHERE special_id = 1";
                    $sqlInsert = "INSERT INTO specials (special_item_starter, special_item_entree, special_item_discount) VALUES ('$starter', '$entree', '$discount')";
                    
                    if ($dbc->query($sqlInsert) === TRUE) {
                        echo "New item has been successfully added to the menu.<br>";
                    } else {
                        echo "Error: " . $sqlInsert . "<br>" . $dbc->error;
                    }
                }            
               ?>
</div>

<center><div>
            
          <!-- form to manage the Daily Special -->

    
          <h1 class="w3-center">Manage Specials</h1><br>
          <div><h2>Add New Special to the Menu: </h2>
          <h3><form border="1" action = "" method = "post">
           <label>Enter Name of Starter:</label> <input type="text" id="starter" name="starter"/><br>
           <label>Enter Name of Entree:</label> <input type="text" id="entree" name="entree"/><br>
           <label>Enter Discount Percentage:</label> <input type="number" id="discount" name="discount"/><br>                 
           <input name="add" type="submit" value="Add New Daily Special">
          </form></h3>
          </div>
          <hr>
                      
</div></center>
    
 
<?php include "./includes/footer.html" ?> 

<script src="./scripts/pizzascripts.js"></script>
 

</body>
</html>

