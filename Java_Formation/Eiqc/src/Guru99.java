
import java.util.List;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;

public class Guru99 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.setProperty ("webdriver.chrome.driver", "C:\\Users\\jpi\\Downloads\\chromedriver_win32\\chromedriver.exe");
		WebDriver driver = new ChromeDriver ();
		
//		driver.manage ().window().maximize();

		driver.get ("http://demo.guru99.com/test/ajax.html");

		// Trouvez le bouton radio pour «Non» en utilisant son ID et cliquez dessus
		driver.findElement (By.id ("no")). click ();
			
		// Cliquez sur le bouton Vérifier
		driver.findElement (By.id ("buttoncheck")). click ();
		
		// Recherchez le texte des boutons radio et imprimez-le sur la console de sortie
		List <WebElement> elements = driver.findElements (By.name ("name"));
	    System.out.println ("Nombre d'éléments:" + elements.size ());

	    for (int i = 0; i <elements.size (); i ++) {
	      System.out.println ("Texte du bouton radio:" + elements.get (i) .getAttribute ("value"));
	    }
	    
		try {
		driver.findElement(By.cssSelector("body > div.container > form > p:nth-child(2) > input[type=reset]:nth-child(1)")).click();
	
		}finally {
    	System.out.println("Well done search test OK");
//        driver.quit();
		}
	}
}

