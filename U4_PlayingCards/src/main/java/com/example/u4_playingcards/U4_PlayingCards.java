package com.example.u4_playingcards;

import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.layout.Pane;
import javafx.stage.Stage;
import javafx.scene.layout.HBox;
import javafx.scene.image.ImageView;
import javafx.scene.image.Image;

public class U4_PlayingCards extends Application {
    @Override
    public void start(Stage stage) {
        Pane pane = new HBox(5);
        Image image1 = new Image("EightClubs.png");
        Image image2 = new Image("JackDiamonds.png");
        Image image3 = new Image("NineHearts.png");
        Image image4 = new Image("ThreeSpades.png");

        pane.getChildren().add(new ImageView(image1));
        pane.getChildren().add(new ImageView(image2));
        pane.getChildren().add(new ImageView(image3));
        pane.getChildren().add(new ImageView(image4));

        Scene scene = new Scene(pane);
        stage.setTitle("Four Playing Cards");
        stage.setScene(scene);
        stage.show();
    }
    public static void main(String[] args) {
        launch();
    }
}