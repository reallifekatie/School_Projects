<?php # PROCESS LOGIN ATTEMPT.
echo "<br><br>";
    
# Check form submitted.
if ( $_SERVER[ 'REQUEST_METHOD' ] == 'POST' )
{
  # Open database connection.
  require ( './includes/header.php' ) ;

  # Get connection, load, and validate functions.
  require ( 'login_tools.php' ) ;
    
  # Check login.
  list ( $check, $data ) = validate ( $dbc, $_POST[ 'email' ], $_POST[ 'pass' ] ) ;

  # On success set session data and display logged in page.
  if ( $check )  
  {
    # Access session.
    session_start();
    $_SESSION[ 'user_id' ] = $data[ 'user_id' ] ;
    $_SESSION[ 'user_fname' ] = $data[ 'user_fname' ] ;
    $_SESSION[ 'user_lname' ] = $data[ 'user_lname' ] ;
    load ( 'manage.php' ) ;
  }
  # Or on failure set errors.
  else { $errors = $data; } 

  # Close database connection.
  mysqli_close( $dbc ) ; 
}

# Continue to display login page on failure.
include ( 'petshop_login.php' ) ;

?>