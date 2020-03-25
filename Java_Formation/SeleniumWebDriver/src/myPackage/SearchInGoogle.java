package myPackage;
//import org.openqa.selenium.*;
import java.awt.*;
import java.awt.event.KeyEvent;

import org.openqa.selenium.By;
//import org.openqa.selenium.By.ByXPath;
import org.openqa.selenium.Keys;
import org.openqa.selenium.WebDriver;

import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
//import org.openqa.selenium.firefox.FirefoxDriver;
//import org.openqa.selenium.ie.InternetExplorerDriver;
//import org.openqa.selenium.interactions.Keyboard;
import org.openqa.selenium.support.ui.WebDriverWait;

//import com.sun.java.swing.plaf.windows.resources.windows;

//import com.sun.javafx.image.impl.BaseIntToByteConverter;

import static org.openqa.selenium.support.ui.ExpectedConditions.presenceOfElementLocated;

//import javax.swing.plaf.basic.BasicSplitPaneUI.KeyboardHomeHandler;

public class SearchInGoogle {

	public static void main(String[] args) throws AWTException {

			System.setProperty("webdriver.chrome.driver","C:\\WebDriver\\chromedriver_win32\\chromedriver.exe");

//			System.setProperty("webdriver.gecko.driver","C:\\Selenium\\geckodriver-v0.26.0-win64\\geckodriver.exe");
			
//			System.setProperty("webdriver.ie.driver", "");
//			WebElement ele = (WebElement) presenceOfElementLocated(By.cssSelector("sdfs"));
			
			
			
	        WebDriver driver = new ChromeDriver();
//	        WebDriver driver = new FirefoxDriver();
	        
//	        driver.manage().window().fullscreen();
	        
	        WebDriverWait wait = new WebDriverWait(driver, 10);
	        
//	        driver.get( "http://www.google.com/webhp?hl=en&amp;tab=ww" );
//	        GoogleSearchPage gsp = new GoogleSearchPage();
//	        gsp.withFluent().setSearchString().clickSearchButton();
	        
	        try {
	            driver.get("https://google.com/");
	            
	            
	            driver.findElement(By.name("q")).sendKeys("cheese" + Keys.ENTER);
	            
	            WebElement cheese = driver.findElement(By.cssSelector("#rso > div:nth-child(2) > div > div > div > div.r > a > h3 > spa"));
	            cheese.click();
	            
	            WebElement firstResult = wait.until(presenceOfElementLocated(By.cssSelector("h3>span")));
	            firstResult.click();
//	            WebElement cheddar = cheese.findElement(By.id("#_PzfpXZreLcKXlwSgwKbwCQ88"));
	            
	            driver.findElement(By.cssSelector("#cheese #cheddar"));
	            
	            System.out.println(firstResult.getAttribute("textContent"));
	            
	            WebElement firstResultCheese = firstResult.findElement(By.xpath("//*[@id=\"rso\"]/div[3]/div/div/div[2]/div[1]/a/h3/span"));
	            
	            firstResultCheese.click();
	            	            
//	            WebElement.sendKeys(Keys.ENTER);
	            driver.navigate().to("http://google.com");
	            driver.findElement(By.name("q")).sendKeys("cnn");
	            
	            Robot r = new Robot();
	            r.keyPress(KeyEvent.VK_ENTER);
	          
	        } finally {
	        	System.out.println("Well done search test OK");
//	            driver.quit();
	        }
	        
	     

	        
	    }

	}


