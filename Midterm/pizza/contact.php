<!DOCTYPE html>
<html>
    <body>
         <?php include "./includes/header.php" ?> 

        <?php
        
    // create variable to contain the database connectivity variables
        $dbc = new mysqli("localhost", "katiesmith", "cnit2648", "pizza");
        
        // if statement to confirm the database exists and to throw an error if it doesn't
        if ($dbc->connect_error) {
            die("Connection failed: " . $dbc->connect_error);
        }
        
        // if statement to create actions for when the user clicks the Submit button
        if (isset($_POST['submit'])) {
            $name = $_POST['name'];
            $people = $_POST['people'];
            $email = $_POST['email'];
            $message = $_POST['message'];
            
            // sql statement variable to insert records into contact table
            $sqlInsert = "INSERT INTO contact (contact_name, number_of_people, contact_email, message) VALUES ('$name', '$people', '$email', '$message')";
            
            // if statement to confirm the new record was saved to the table
            if ($dbc->query($sqlInsert) === TRUE) {
                echo "New record created successfully";
            } else {
                echo "Error: " . $sqlInsert . "<br>" . $dbc->error;
            }
            echo "<br><br><br><hr>";
        }
        ?>
       
        <!-- div container to hold the form to capture the user's input -->
        <div class="w3-container w3-padding-64 w3-blue-grey w3-grayscale-min w3-xlarge">
          <div class="w3-content">
            <h1 class="w3-center w3-jumbo" style="margin-bottom:64px">Contact</h1>
            <p>Find us at some address at some place or call us at 05050515-122330</p>
            <p><span class="w3-tag">FYI!</span> We offer full-service catering for any event, large or small. We understand your needs and we will cater the food to satisfy the biggest criteria of them all, both look and taste.</p>
            <p class="w3-xxlarge"><strong>Reserve</strong> a table, ask for today's special or just send us a message:</p>
            <!-- form for user input -->
            <form action="" method="post">
                  <p><input class="w3-input w3-padding-16 w3-border" type="text" placeholder="Name" name="name"></p>
                  <p><input class="w3-input w3-padding-16 w3-border" type="number" placeholder="How many people" name="people"></p>
                  <p><input class="w3-input w3-padding-16 w3-border" type="text"   placeholder="Email Address" name="email"></p>
                  <p><input class="w3-input w3-padding-16 w3-border" type="text" placeholder="Message \ Special requirements" name="message"></p>
                  <p><button class="w3-button w3-light-grey w3-block" name="submit" type="submit">Add Contact Information</button></p>
            </form>
          </div>
        </div>
 <!-- Image of location/map -->
        <img src="./images/map.jpg" class="w3-image w3-greyscale" style="width:100%;" id="myMap">

        <?php include "./includes/footer.html" ?> 

        <script src="./scripts/pizzascripts.js"></script>

</body>
</html>

