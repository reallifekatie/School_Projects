
<!DOCTYPE html>
<html>
<?php include "./includes/catering_header.php" ?>
    <body>
    <!-- Menu Section -->
      <div class="w3-row w3-padding-64" id="menu">
        <div class="w3-col l6 w3-padding-large">
          <h1 class="w3-center">Our Menu</h1><br>

            <?php
    
                # Access session.
                session_start() ; 

                # Redirect if not logged in.
                if ( !isset( $_SESSION[ 'user_id' ] ) ) { require ( 'login_tools.php' ) ; load() ; }

                # Display body section.
                echo "<p>You are now logged in, {$_SESSION['first_name']} {$_SESSION['last_name']} </p>";
    
                $conn = new mysqli("localhost", "katiesmith", "cnit2648", "catering");
    
                if ($conn->connect_error) {
                    die("Connection failed: " . $conn->connect_error);
                }
    
                // add new menu item
                if (isset($_POST['add'])) {
                    $name = $_POST['name'];
                    $descr = $_POST['description'];
                    $price = $_POST['price'];
                    $sqlInsert = "INSERT INTO menu (name, description, price) VALUES ('$name', '$descr', '$price')";
                    if ($conn->query($sqlInsert) === TRUE) {
                        echo "New item has been successfully added to the menu.<br>";
                    } else {
                        echo "Error: " . $sqlInsert . "<br>" . $conn->error;
                    }
                }            
                // update menu item
                if (isset($_POST['update'])) {
                    $id = $_POST['id'];
                    $name = $_POST['name'];
                    $descr = $_POST['description'];
                    $price = $_POST['price'];
                    $sqlUpdate = "UPDATE menu SET name = '$name', description = '$descr', price = '$price' WHERE id = '$id'";
                    if ($conn->query($sqlUpdate) === TRUE) {
                        echo "Menu item has been updated.";
                    } else {
                        echo "Error: " . $sqlUpdate . "<br>" . $conn->error;
                    }
                }  
                // delete menu item
                if (isset($_POST['delete'])) {
                    $id = $_POST['id'];
                    $sqlDelete = "DELETE FROM menu WHERE id = '$id'";
                    if ($conn->query($sqlDelete) === TRUE) {
                        echo "Menu item has been successfully removed from the menu.<br>";
                    } else {
                        echo "Error: " . $sqlDelete . "<br>" . $conn->error;
                    }
                }    
                
                $sql = "SELECT id, name, description, price, price FROM menu";
                $result = $dbc->query($sql);

                if ($result->num_rows > 0) {
                    // output data of each row
                    while($row = $result->fetch_assoc()) {
                       echo "id: {$row['id']}<br> Name: {$row['name']} <br>Description: {$row['description']}<br> Price:{$row['price']} <hr>  ";
                    } 
                } else {
                    echo "0 results";
                }
                echo "<br><br><br><hr>";
    
               ?>

        </div>

        <div class="w3-col l6 w3-padding-large">
            
          <!-- add forms here -->
            
          <h1 class="w3-center">Manage Menu</h1><br>
          <h4>Add New Menu Item: </h4>
          <form border="1" action = "" method = "post">
            Name: <input type="text" id="name" name="name" /><br>
            Description: <input type="text" id="description" name="description" /> <br>
            Price: <input type="text" id="price" name="price" /> <br>
            <input name="add" type="submit" value="Add New Menu Item">
          </form>
          <hr>
          
          <h4>Update Menu Item: </h4>
          <form border="1" action = "" method = "post">
            ID: <input type="text" name="id" /><br>
            Name: <input type="text" id="name" name="name" /><br>
            Description: <input type="text" id="description" name="description" /> <br>
            Price: <input type="text" id="price" name="price" /> <br>
            <input name="update" type="submit" value="Update Menu Item">
          </form>
          <hr>
          
          <h4>Delete Menu Item: </h4>
          <form border="1" action = "" method = "post">
            ID: <input type="text" name="id" /> <br>
            <input name="delete" type="submit" value="Delete Menu Item">
          </form>
          <hr>
            
            <?php echo '<h1><a href="goodbye.php">Logout</a></h1>' ?>
        </div>
      </div>

     <hr>
     <?php include "./includes/catering_footer.php" ?>
    </body>
  </html>
