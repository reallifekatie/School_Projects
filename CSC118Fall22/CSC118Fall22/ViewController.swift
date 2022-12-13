//
//  ViewController.swift
//  CSC118Fall22
//
//  Created by Administrator on 11/27/22.
//

import UIKit
import AVFoundation  // used for sound

class ViewController: UIViewController {
    
    @IBOutlet var headerOutlet: UILabel!

    @IBOutlet var totalsLabel: UILabel!
    
    var accumulator = 0
    
    var audio:AVPlayer! // used for sound
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
    }
    
    @IBAction func buttonPress(_sender: UIButton) {
        playAnimalSound(_sender:_sender)
    }
         
    @IBAction func resetButton(_ sender: Any) {
        totalsLabel.text = String(0)
    }
    
    func playAnimalSound(_sender: UIButton) {
            
        var url  = Bundle.main.url(forResource: nil, withExtension:nil)
            
             
                // need to declare local path as url
        switch _sender.tag {
        case 1:
            url = Bundle.main.url(forResource: "elephant", withExtension: "mp3");
            headerOutlet.text = "This is what an elephant sounds like!";
            accumulator += 10;
            totalsLabel.text = String(accumulator);
            let alertController = UIAlertController(title: "Elephant", message: "Largest existing land animals. You can tell the 3 species apart by their ears. They have around 150,000 muscle units in their trunk.", preferredStyle: UIAlertController.Style.alert)
            alertController.addAction(UIAlertAction(title: "OK", style: UIAlertAction.Style.default, handler: nil))
            present(alertController, animated: true, completion: nil);
        case 2:
            url = Bundle.main.url(forResource: "leopard", withExtension: "mp3");
            headerOutlet.text = "This is what a leopard sounds like!";
            accumulator -= 10;
            totalsLabel.text = String(accumulator);
            let alertController = UIAlertController(title: "Leopard", message: "Leopards are predominantly solitary animals that have large territories. They growl when angry & purr when content.", preferredStyle: UIAlertController.Style.alert)
            alertController.addAction(UIAlertAction(title: "OK", style: UIAlertAction.Style.default, handler: nil))
            present(alertController, animated: true, completion: nil);
        case 3:
            url = Bundle.main.url(forResource: "lion", withExtension: "mp3");
            headerOutlet.text = "This is what a lion sounds like!";
            accumulator += 20;
            totalsLabel.text = String(accumulator);
            let alertController = UIAlertController(title: "Lion", message: "Lions are the only cat that live in groups. Female lions are the main hunters. Their roar can be heard from up to 8 km away.", preferredStyle: UIAlertController.Style.alert)
            alertController.addAction(UIAlertAction(title: "OK", style: UIAlertAction.Style.default, handler: nil))
            present(alertController, animated: true, completion: nil);
        case 4:
            url = Bundle.main.url(forResource: "ostrich", withExtension: "mp3");
            headerOutlet.text = "This is what an ostrich sounds like!";
            accumulator -= 20;
            totalsLabel.text = String(accumulator);
            let alertController = UIAlertController(title: "Ostrich", message: "They may not be able to fly, but no other bird can match their speed on land. They've been clocked up to 43 mph.", preferredStyle: UIAlertController.Style.alert)
            alertController.addAction(UIAlertAction(title: "OK", style: UIAlertAction.Style.default, handler: nil))
            present(alertController, animated: true, completion: nil);
        case 5:
            url = Bundle.main.url(forResource: "yak", withExtension: "mp3");
            headerOutlet.text = "This is what a yak sounds like!";
            accumulator += 30;
            totalsLabel.text = String(accumulator);
            let alertController = UIAlertController(title: "Yak", message: "Yaks are herbivores and munch on grass. Wild males can reach a height of 6.5 ft and weigh as much as 2,200 lbs.", preferredStyle: UIAlertController.Style.alert)
            alertController.addAction(UIAlertAction(title: "OK", style: UIAlertAction.Style.default, handler: nil))
            present(alertController, animated: true, completion: nil);
        case 6:
            url = Bundle.main.url(forResource: "zebra", withExtension: "mp3");
            headerOutlet.text = "This is what a zebra sounds like!";
            accumulator -= 30;
            totalsLabel.text = String(accumulator);
            let alertController = UIAlertController(title: "Zebra", message: "Zebras stripes are as unique as human fingerprints. Each species has different types of stripes. These crazy animals sleep standing up.", preferredStyle: UIAlertController.Style.alert)
            alertController.addAction(UIAlertAction(title: "OK", style: UIAlertAction.Style.default, handler: nil))
            present(alertController, animated: true, completion: nil);
        default:
            print("nothing");
        }
        // now use declared path 'url' to initialize the player
        audio = AVPlayer.init(url: url!)
        // after initialization play audio its just like click on play button
        audio.play()
    }
}

