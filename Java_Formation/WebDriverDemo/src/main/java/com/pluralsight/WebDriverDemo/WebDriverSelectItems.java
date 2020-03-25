package com.pluralsight.WebDriverDemo;

//import org.apache.bcel.generic.Select;
import org.openqa.selenium.support.ui.Select;

import java.util.List;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;

public class WebDriverSelectItems {

	public static void main(String[] args) {
		
		System.setProperty("webdriver.chrome.driver","C:\\WebDriver\\chromedriver_win32\\chromedriver.exe");
	
		WebDriver driver = new ChromeDriver();
		driver.get("file:///D:/repos/Projets/Java_Formation/WebDriverDemo/src/main/java/Select.html");
		
		WebElement selectElement = driver.findElement(By.id("select1"));
		
		Select select = new Select(selectElement);
		
		select.selectByVisibleText("Maybe"); 		// Maybe
		
		select.selectByIndex(3); 	// Hema 2000

		List <WebElement> optListes = select.getOptions();
		for (WebElement ele : optListes) {
			System.out.println(ele.getText());
			
		}
		
		List <WebElement> opt = select.getOptions();	
		String element = opt.get(4).getText(); 		// Hema 3000
	}

}
