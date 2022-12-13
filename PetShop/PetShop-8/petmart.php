<!DOCTYPE html >
<!--  Website template by freewebsitetemplates.com  -->
<html>
    <?php include("./includes/header.php");?>

 	<div id="body">
			
			       <div id="content">
				         
						 
						 <div class="search">
									<input type="text" name="s" value="Find"><button>&nbsp;</button>
									<label for="articles"><input type="radio" id="articles"> Articles</label>
									<label for="products"><input type="radio" id="products" checked> PetMart Products</label>
								</div>
								
				        <div class="content">
												        
								<ul>
									<li>
                                        <?php
                                            $sqlFood = "SELECT * FROM petshop.petmart WHERE petmart_category = 'Food Area'";
                                            $result = $dbc->query($sqlFood);
                                            $row = $result->fetch_assoc();
                                            echo "<img src='{$row['petmart_image']}'>";
                                            echo "<h2>{$row['petmart_category']}</h2>";
                                            //$newColumn = 0;
                                            if ( $result->num_rows > 0 ) {
                                                while ($row = $result->fetch_assoc()) {
                                                    echo "<span><a href={$row['petmart_listing_link']}>{$row['petmart_listing']}</a></span>";
                                                }
                                            }
                                        ?>	
									</li>
                                    
									<li>
										<?php
                                            $sqlAccessories = "SELECT * FROM petshop.petmart WHERE petmart_category = 'Accessories'";
                                            $result = $dbc->query($sqlAccessories);
                                            $row = $result->fetch_assoc();
                                            echo "<img src='{$row['petmart_image']}'>";
                                            echo "<h2>{$row['petmart_category']}</h2>";
                                            //$newColumn = 0;
                                            if ( $result->num_rows > 0 ) {
                                                while ($row = $result->fetch_assoc()) {
                                                    echo "<span><a href={$row['petmart_listing_link']}>{$row['petmart_listing']}</a></span>";
                                                }
                                            }
                                        ?>
									</li>
                                    
									<li>
										<?php
                                            $sqlTraining = "SELECT * FROM petshop.petmart WHERE petmart_category = 'Training & Behavior'";
                                            $result = $dbc->query($sqlTraining);
                                            $row = $result->fetch_assoc();
                                            echo "<img src='{$row['petmart_image']}'>";
                                            echo "<h2>{$row['petmart_category']}</h2>";
                                            //$newColumn = 0;
                                            if ( $result->num_rows > 0 ) {
                                                while ($row = $result->fetch_assoc()) {
                                                    echo "<span><a href={$row['petmart_listing_link']}>{$row['petmart_listing']}</a></span>";
                                                }
                                            }
                                        ?>
									</li>
                                    
									<li>
										<?php
                                            $sqlHealth = "SELECT * FROM petshop.petmart WHERE petmart_category = 'Health Center'";
                                            $result = $dbc->query($sqlHealth);
                                            $row = $result->fetch_assoc();
                                            echo "<img src='{$row['petmart_image']}'>";
                                            echo "<h2>{$row['petmart_category']}</h2>";
                                            //$newColumn = 0;
                                            if ( $result->num_rows > 0 ) {
                                                while ($row = $result->fetch_assoc()) {
                                                    echo "<span><a href={$row['petmart_listing_link']}>{$row['petmart_listing']}</a></span>";
                                                }
                                            }
                                        ?>
									</li>
                                    
									<li>
										<?php
                                            $sqlTravel = "SELECT * FROM petshop.petmart WHERE petmart_category = 'Travel Essentials'";
                                            $result = $dbc->query($sqlTravel);
                                            $row = $result->fetch_assoc();
                                            echo "<img src='{$row['petmart_image']}'>";
                                            echo "<h2>{$row['petmart_category']}</h2>";
                                            //$newColumn = 0;
                                            if ( $result->num_rows > 0 ) {
                                                while ($row = $result->fetch_assoc()) {
                                                    echo "<span><a href={$row['petmart_listing_link']}>{$row['petmart_listing']}</a></span>";
                                                }
                                            }
                                        ?>
									</li>
                                    
									<li>
										<?php
                                            $sqlGroom = "SELECT * FROM petshop.petmart WHERE petmart_category = 'Grooming'";
                                            $result = $dbc->query($sqlGroom);
                                            $row = $result->fetch_assoc();
                                            echo "<img src='{$row['petmart_image']}'>";
                                            echo "<h2>{$row['petmart_category']}</h2>";
                                            //$newColumn = 0;
                                            if ( $result->num_rows > 0 ) {
                                                while ($row = $result->fetch_assoc()) {
                                                    echo "<span><a href={$row['petmart_listing_link']}>{$row['petmart_listing']}</a></span>";
                                                }
                                            }
                                        ?>
									</li>
								</ul>
						</div>
						
					    <div id="sidebar">						
								   <a href="petmart.html"><img src="images/discount.jpg" width="300" height="790" alt="Pet Shop" title="Pet Shop"></a> 		
					    </div>
				   </div>
				   
				   <div class="featured">
				        <ul>
							<li><a href="index.html"><img src="images/organic-and-chemical-free.jpg" width="300" height="90" alt="Pet Shop" title="Pet Shop" ></a></li>
							<li><a href="index.html"><img src="images/good-food.jpg" width="300" height="90" alt="Pet Shop" title="Pet Shop" ></a></li>
							<li class="last"><a href="index.html"><img src="images/pet-grooming.jpg" width="300" height="90" alt="Pet Shop" title="Pet Shop" ></a></li>
						</ul>
				        
				   </div>
			</div>
			<div id="footer">
			        <div class="section">
						<ul>
							<li>
								<img src="images/friendly-pets.jpg" width="240" height="186" alt="Pet Shop" title="Pet Shop">
								<h2><a href="index.php">Friendly Pets</a></h2>
								<p>
								   Lorem ipsum dolor sit amet, consectetuer adepiscing elit,  sed diam nonummy nib. <a class="more" href="index.php">Read More</a> 
								</p>
							</li>	
							<li>
								<img src="images/pet-lover2.jpg" width="240" height="186" alt="Pet Shop" title="Pet Shop">
								<h2><a href="index.php">How dangerous are they</a></h2>
								<p>
								   Lorem ipsum dolor sit amet, cons ectetuer adepis cing, sed diam euis. <a class="more" href="index.php">Read More</a> 
								</p>
							</li>	
							<li>
								<img src="images/healthy-dog.jpg" width="240" height="186" alt="Pet Shop" title="Pet Shop">
								<h2><a href="index.php">Keep them healthy</a></h2>
								<p>
								   Lorem ipsum dolor sit amet, consectetuer adepiscing elit,  sed diam nonu mmy. <a class="more" href="index.php">Read More</a> 
								</p>
							</li>	
							<li>		
								<h2><a href="index.php">Love...love...love...pets</a></h2>
								<p>
								     Lorem ipsum dolor sit amet, consectetuer adepiscing elit,  sed diameusim. <a class="more" href="index.php">Read More</a> 
								</p>
								<img src="images/pet-lover.jpg" width="240" height="186" alt="Pet Shop" title="Pet Shop">
							</li>	
						</ul>
					</div>
					<div id="footnote">
						<div class="section">
						   &copy; 2011 <a href="index.php">Petshop</a>. All Rights Reserved.
						</div>
					</div>
			</div>
</html>