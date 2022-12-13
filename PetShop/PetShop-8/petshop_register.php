<?php # DISPLAY COMPLETE REGISTRATION PAGE.

# Set page title and display header section.
$page_title = 'Register' ;
include ( './includes/header.php' ) ;

# Check form submitted.
if ( $_SERVER[ 'REQUEST_METHOD' ] == 'POST' )
{
  # Connect to the database.
  require ('./includes/connect_db.php'); 
  
  # Initialize an error array.
  $errors = array();

  # Check for a first name.
  if ( empty( $_POST[ 'user_fname' ] ) )
  { $errors[] = 'Enter your first name.' ; }
  else
  { $fn = mysqli_real_escape_string( $dbc, trim( $_POST[ 'user_fname' ] ) ) ; }

  # Check for a last name.
  if (empty( $_POST[ 'user_lname' ] ) )
  { $errors[] = 'Enter your last name.' ; }
  else
  { $ln = mysqli_real_escape_string( $dbc, trim( $_POST[ 'user_lname' ] ) ) ; }

  # Check for an email address:
  if ( empty( $_POST[ 'user_email' ] ) )
  { $errors[] = 'Enter your email address.'; }
  else
  { $e = mysqli_real_escape_string( $dbc, trim( $_POST[ 'user_email' ] ) ) ; }

  # Check for a password and matching input passwords.
  if ( !empty($_POST[ 'pass1' ] ) )
  {
    if ( $_POST[ 'pass1' ] != $_POST[ 'pass2' ] )
    { $errors[] = 'Passwords do not match.' ; }
    else
    { $p = mysqli_real_escape_string( $dbc, trim( $_POST[ 'pass1' ] ) ) ; }
  }
  else { $errors[] = 'Enter your password.' ; }
  
  # Check if email address already registered.
  if ( empty( $errors ) )
  {
    $q = "SELECT user_id FROM users WHERE user_email='$e'" ;
    $r = @mysqli_query ( $dbc, $q ) ;
    if ( mysqli_num_rows( $r ) != 0 ) $errors[] = '<h3>Email address already registered. <a href="petshop_login.php">Login</a></h3>' ;
  }
  
  # On success register user inserting into 'users' database table.
  if ( empty( $errors ) ) 
  {
    $q = "INSERT INTO users (user_fname, user_lname, user_email, user_password) VALUES ('$fn', '$ln', '$e', SHA2('$p',256))";
    $r = @mysqli_query ( $dbc, $q ) ;
    if ($r)
    { echo '<h1>Registered!<p>You are now registered.</p><p><a href="petshop_login.php">Login</a></h1></p>'; }
  
    # Close database connection.
    mysqli_close($dbc); 
    
  }
  # Or report errors.
  else 
  {
    echo '<h1>Error!</h1><p id="err_msg"><h3>The following error(s) occurred:</h3><br>' ;
    foreach ( $errors as $msg )
    { echo " - $msg<br>" ; }
    echo '<h3>Please try again.</h3></p>';
    # Close database connection.
    mysqli_close( $dbc );
  }  
}
?>

<!-- Display body section with sticky form. -->
<br><br>
<h1>Register</h1>
<form action="petshop_register.php" method="post">
<p><h3>First Name: <input type="text" name="user_fname" size="20" value="<?php if (isset($_POST['user_fname'])) echo $_POST['user_fname']; ?>"> 
Last Name: <input type="text" name="user_lname" size="20" value="<?php if (isset($_POST['user_lname'])) echo $_POST['user_lname']; ?>"></h3></p>
<p><h3>Email Address: <input type="text" name="user_email" size="50" value="<?php if (isset($_POST['user_email'])) echo $_POST['user_email']; ?>"></h3></p>
<p><h3>Password: <input type="user_password" name="pass1" size="20" value="<?php if (isset($_POST['pass1'])) echo $_POST['pass1']; ?>" >
Confirm Password: <input type="user_password" name="pass2" size="20" value="<?php if (isset($_POST['pass2'])) echo $_POST['pass2']; ?>"></h3></p>
<p><h3><input type="submit" value="Register"></h3></p>
</form>

<?php 

exit();
?>
