<!DOCTYPE html>
<html>
   
<body>
 <?php include "./includes/header.php" ?>


<!-- About Container -->
<div class="w3-container w3-padding-64 w3-red w3-grayscale w3-xlarge" id="about">
  <?php
    
    
                # Access session.
                session_start() ; 

                # Redirect if not logged in.
                if ( !isset( $_SESSION[ 'user_id' ] ) ) { require ( 'login_tools.php' ) ; load() ; }

                # Display body section.
                echo "<p>You are now logged in, {$_SESSION['first_name']} {$_SESSION['last_name']} </p>";
    
                $dbc = new mysqli("localhost", "katiesmith", "cnit2648", "pizza");
    
                if ($dbc->connect_error) {
                    die("Connection failed: " . $dbc->connect_error);
                }
    
                // add new menu item
                if (isset($_POST['add'])) {
                    $name = $_POST['name'];
                    $emphasis = $_POST['emphasis'];
                    $category = $_POST['category'];
                    $descr = $_POST['description'];
                    $price = $_POST['price'];
                    $sqlInsert = "INSERT INTO menu (menu_item_category, menu_item_name, menu_item_description, menu_item_emphasis, menu_item_price) VALUES ('$category', '$name', '$descr', '$emphasis', '$price')";
                    if ($dbc->query($sqlInsert) === TRUE) {
                        echo "New item has been successfully added to the menu.<br>";
                    } else {
                        echo "Error: " . $sqlInsert . "<br>" . $dbc->error;
                    }
                }            
                // update menu item
                if (isset($_POST['update'])) {
                    $id = $_POST['id'];
                    $name = $_POST['name'];
                    $emphasis = $_POST['emphasis'];
                    $category = $_POST['category'];
                    $descr = $_POST['description'];
                    $price = $_POST['price'];
                    $sqlUpdate = "UPDATE menu SET menu_item_category = '$category', menu_item_name = '$name', menu_item_description = '$descr', menu_item_emphasis = '$emphasis', menu_item_price = '$price' WHERE menu_item_id = '$id'";
                    if ($dbc->query($sqlUpdate) === TRUE) {
                        echo "Menu item has been updated.";
                    } else {
                        echo "Error: " . $sqlUpdate . "<br>" . $dbc->error;
                    }
                }  
                // delete menu item
                if (isset($_POST['delete'])) {
                    $name = $_POST['name'];
                    $sqlDelete = "DELETE FROM menu WHERE menu_item_id = '$name'";
                    if ($dbc->query($sqlDelete) === TRUE) {
                        echo "Menu item has been successfully removed from the menu.<br>";
                    } else {
                        echo "Error: " . $sqlDelete . "<br>" . $dbc->error;
                    }
                }    
               ?>
</div>

<center><div>
            
          <!-- forms to manage the menu with Add, Update, & Delete -->
            
          <h1 class="w3-center">Manage Menu</h1><br>
          <div><h2>Add New Menu Item: </h2>
          <h4><form border="1" action = "" method = "post">
            Name: <input type="text" id="name" name="name" /><br>
            Emphasis: <input type="text" id="emphasis" name="emphasis" /><br>
            Category: <input type="text" id="category" name="category" /><br>
            Description: <input type="text" id="description" name="description" /> <br>
            Price: <input type="text" id="price" name="price" /> <br>
            <input name="add" type="submit" value="Add New Menu Item">
          </form></h4>
          </div>
          <hr>
          
          <h2>Update Menu Item: </h2>
          <h4><form border="1" action = "" method = "post">
            ID: <input type="text" name="id" /><br>
            Name: <input type="text" id="name" name="name" /><br>
            Emphasis: <input type="text" id="emphasis" name="emphasis" /><br>
            Category: <input type="text" id="category" name="category" /><br>
            Description: <input type="text" id="description" name="description" /> <br>
            Price: <input type="text" id="price" name="price" /> <br>
            <input name="update" type="submit" value="Update Menu Item">
          </form></h4>
          <hr>
          
          <h2>Delete Menu Item: </h2>
          <h4><form border="1" action = "" method = "post">
            Name: <input type="text" id="name" name="name" /><br>
            <input name="delete" type="submit" value="Delete Menu Item">
          </form></h4>
          <hr>
    
    <?php echo '<h1><a href="goodbye.php">Logout</a></h1>' ?>
            
</div></center>
    
 
<?php include "./includes/footer.html" ?> 

<script src="./scripts/pizzascripts.js"></script>
 

</body>
</html>

