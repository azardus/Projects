package com.pluralsight.WebDriverDemo;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;
//import org.openqa.selenium.firefox.FirefoxDriver;

public class WebDriverDemo {

	public static void main(String[] args) {
		
//		System.setProperty("webdriver.gecko.driver", "C:\\Users\\jpi\\Downloads\\geckodriver-v0.26.0-win64\\geckodriver.exe");
//		WebDriver driver = new FirefoxDriver();
		
		
		System.setProperty("webdriver.chrome.driver","C:\\WebDriver\\chromedriver_win32\\chromedriver.exe");
		WebDriver driver = new ChromeDriver();
		driver.get("http://www.pluralsight.com");

		
		driver.get("https://google.com/");
		WebElement searchField = driver.findElement(By.name("q"));
		searchField.sendKeys("pluralsight");
		searchField.submit();
		
//		Wait implicite
//		driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
		
//		Wait explice est plus effiçace
		WebDriverWait wait = new WebDriverWait(driver, 10);
		wait.until(ExpectedConditions.presenceOfElementLocated(By.linkText("Images")));
		
		WebElement imagesLink = driver.findElements(By.linkText("Images")).get(0);
		imagesLink.click();
		
//		WebElement 
	}

}
