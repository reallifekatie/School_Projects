<!DOCTYPE html>
<html>
    <body>
        <?php include "./includes/catering_header.php" ?>
        
        <?php
        $conn = new mysqli("localhost", "katiesmith", "cnit2648", "catering");
        if ($conn->connect_error) {
            die("Connection failed: " . $conn->connect_error);
        }
        
        if (isset($_POST['submit'])) {
            $name = $_POST['name'];
            $number = $_POST['number'];
            $email = $_POST['email'];
            $message = $_POST['message'];
            $sqlInsert = "INSERT INTO contact (name, number_of_people, email, message) VALUES ('$name', '$number', '$email', '$message')";
            
            if ($conn->query($sqlInsert) === TRUE) {
                echo "New record created successfully";
            } else {
                echo "Error: " . $sqlInsert . "<br>" . $conn->error;
            }
            echo "<br><br><br><hr>";
        }
        ?>
        
        <!-- Contact Section -->
          <div class="w3-container w3-padding-64" id="contact">
            <h1>Contact</h1><br>
            <p>We offer full-service catering for any event, large or small. We understand your needs and we will cater the food to satisfy the biggerst criteria of them all, both look and taste. Do not hesitate to contact us.</p>
            <p class="w3-text-blue-grey w3-large"><b>Catering Service, 42nd Living St, 43043 New York, NY</b></p>
            <p>You can also contact us by phone 00553123-2323 or email catering@catering.com, or you can send us a message here:</p>
              
            <!-- NOTE: We are not going to save the date/time at this time -->
              
            <form action="" method="post">
                <p><input class="w3-input w3-padding-16" type="text" placeholder="Name" required name="name"></p>
                <p><input class="w3-input w3-padding-16" type="number" placeholder="How many people"  name="number"></p>
                <p><input class="w3-input w3-padding-16" type="datetime-local" placeholder="Date and time"  name="date" value="2020-11-16T20:00"></p>
                <p><input class="w3-input w3-padding-16" type="text" placeholder="Email" name="email"></p>
                <p><input class="w3-input w3-padding-16" type="text" placeholder="Message \ Special requirements" required name="message"></p>
                <p><button class="w3-button w3-light-grey w3-section" type="submit" name="submit"> Save Contact Info </button></p>
            </form>
              
              
          </div>
        <?php include "./includes/catering_footer.php" ?>
    </body>
</html>