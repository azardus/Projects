package com.pluralsight.WebDriverDemo;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;

public class WebDriverTables {

	public static void main(String[] args) {
		
		System.setProperty("webdriver.chrome.driver","C:\\WebDriver\\chromedriver_win32\\chromedriver.exe");
				
		WebDriver driver = new	ChromeDriver();
		driver.get("file:///D:/repos/Projets/Java_Formation/WebDriverDemo/src/main/java/Table.html");
		
		
		WebElement outerTable = driver.findElement(By.tagName("table"));
		WebElement innerTable = outerTable.findElement(By.tagName("table"));
		WebElement row1 = innerTable.findElements(By.tagName("tr")).get(0);
		System.out.println(row1.getText());
		
		String row = row1.getText();
		row = "Nouvelle valeur de ma row1";
		System.out.println(row);
		
		
		
		WebElement row2 = driver.findElement(By.xpath("/html/body/table/tbody/tr/td[2]/table/tbody/tr[2]/td"));
		System.out.println(row2.getText());
		
		
	}

}
