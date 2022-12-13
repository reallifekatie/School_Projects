<!DOCTYPE html >
<!--  Website template by freewebsitetemplates.com  -->
  <?php include("./includes/header.php");?>
			
			<div id="body">
			
			       <div id="content">
				   
				        <div class="content">
							   <h2>Pet Guide</h2>
							   <div>
								   <p>
									  Here are some useful pet quide tips for your pets. Easy and convenient for you to learn more on how to understand them. basic intructions to useful information not just for your pet but also for other animals. 
								   </p>
							   </div>
							   <ul class="section">
									<li>
                                        <?php
                                            $sql = "SELECT * FROM petshop.petguide WHERE petguide_header = 'Pet Training Guides'";
                                            $result = $dbc->query($sql);
                                            $row = $result->fetch_assoc();
                                            echo "<h2>{$row['petguide_header']}</h2>";
                                            echo "<p>{$row['petguide_blurb']}</p>";
                                        ?>
									</li>
									<li>
										<?php
                                            $sql = "SELECT * FROM petshop.petguide WHERE petguide_header = 'Make Them Behave'";
                                            $result = $dbc->query($sql);
                                            $row = $result->fetch_assoc();
                                            echo "<h2>{$row['petguide_header']}</h2>";
                                            echo "<p>{$row['petguide_blurb']}</p>";
                                        ?>
									</li>	
									<li>
										<?php
                                            $sql = "SELECT * FROM petshop.petguide WHERE petguide_header = 'Food They Need'";
                                            $result = $dbc->query($sql);
                                            $row = $result->fetch_assoc();
                                            echo "<h2>{$row['petguide_header']}</h2>";
                                            echo "<p>{$row['petguide_blurb']}</p>";
                                        ?>
									</li>
									<li>
										<?php
                                            $sql = "SELECT * FROM petshop.petguide WHERE petguide_header = 'Dos and Donts'";
                                            $result = $dbc->query($sql);
                                            $row = $result->fetch_assoc();
                                            echo "<h2>{$row['petguide_header']}</h2>";
                                            echo "<p>{$row['petguide_blurb']}</p>";
                                        ?>
									</li>
									<li>
										<?php
                                            $sql = "SELECT * FROM petshop.petguide WHERE petguide_header = 'Pet Foods'";
                                            $result = $dbc->query($sql);
                                            $row = $result->fetch_assoc();
                                            echo "<h2>{$row['petguide_header']}</h2>";
                                            echo "<p>{$row['petguide_blurb']}</p>";
                                        ?>
									</li>
									<li>
										<?php
                                            $sql = "SELECT * FROM petshop.petguide WHERE petguide_header = 'Healthy Recipes for Pets'";
                                            $result = $dbc->query($sql);
                                            $row = $result->fetch_assoc();
                                            echo "<h2>{$row['petguide_header']}</h2>";
                                            echo "<p>{$row['petguide_blurb']}</p>";
                                        ?>
									</li>
								</ul>
								<div class="paging">
								   <a class="active" href="petguide.php">1</a>
								   <a href="petguide.php">2</a>
								   <a href="petguide.php">3</a>
								   <a href="petguide.php">4</a>
								   <a class="next" href="petguide.php">NEXT</a>
								</div>   
						</div>
						
					    <div id="sidebar">
						
						     <div id="section">
							    <div>
							      <div>
							           <h2>Pet Guide Overview</h2>
										<ul>
											<li><a href="petguide.php">Pet Trainging Guides <span>(1)</span> </a></li>
											<li><a href="petguide.php">Behavior Training <span>(11)</span> </a></li>
											<li><a href="petguide.php">Pet Recipes <span>(3)</span> </a></li>
											<li><a href="petguide.php">Do's and Don'ts <span>(8)</span> </a></li>
											<li><a href="petguide.php">Pet Foods <span>(3)</span> </a></li>
											<li><a href="petguide.php">Cosplay Pets <span>(2)</span> </a></li>
											<li><a href="petguide.php">Shopping Guides <span></span> </a></li>
											<li><a href="petguide.php">Pregnancy and Nursing Pets <span>(8)</span> </a></li>
											<li><a href="petguide.php">Medications <span>(7)</span> </a></li>
											<li><a href="petguide.php">Excercise <span>(7)</span> </a></li>
											<li><a href="petguide.php">Diet <span>(10)</span> </a></li>
											<li><a href="petguide.php">Grooming <span>(1)</span> </a></li>
											<li><a href="petguide.php">Cosplay Pets <span>(2)</span> </a></li>
											<li><a href="petguide.php">Shopping Guides <span></span> </a></li>
											<li><a href="petguide.php">Pregnancy and Nursing Pets <span>(8)</span> </a></li>
											<li><a href="petguide.php">Medications <span>(7)</span> </a></li>
											<li><a href="petguide.php">Excercise <span>(7)</span> </a></li>
											<li><a href="petguide.php">Diet <span>(10)</span> </a></li>
											<li><a href="petguide.php">Grooming <span>(1)</span> </a></li>
										</ul>
							      </div>
							    </div>
							 </div>
					    </div>
				   </div>
				   
				   <div class="featured">
				        <ul>
							<li><a href="index.php"><img src="images/organic-and-chemical-free.jpg" width="300" height="90" alt="Pet Shop" title="Pet Shop" ></a></li>
							<li><a href="index.php"><img src="images/good-food.jpg" width="300" height="90" alt="Pet Shop" title="Pet Shop" ></a></li>
							<li class="last"><a href="index.php"><img src="images/pet-grooming.jpg" width="300" height="90" alt="Pet Shop" title="Pet Shop" ></a></li>
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
			