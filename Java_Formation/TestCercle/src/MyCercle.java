
public class MyCercle {

	private double _rayon;
//	private double _centerOfCercle;
	private double _x;
	private double _y;
	
	 MyCercle (){
		
	 }
	
	 MyCercle (double surface) {
		
	}
	
	public void setCenter (double x, double y) {
		this._x = x;
		this._y = y;
	}
	
	public void setRayon (double rayon) {
		this._rayon = rayon;
	}
	
	public double surface(double rayon) {
		double pi = Math.PI;
		double surface = pi * rayon * rayon;
		return surface;
	}
	
	boolean isInternal(double x, double y) {
//		double surfaceInital = surface(this._rayon);
//		double surfaceIsInternal = 
		return ( (x-this._x) * (x-this._x) + (y-this._y) * (y*this._y) <= this._rayon * this._rayon );
	}
	
	
	public static void main(String[] args) {
		
		MyCercle c1 = new MyCercle();
		c1.setCenter(1, 1);
		c1.setRayon(2);
		c1.surface(2);
		System.out.println(" La surface de C1 :" + c1.surface(2) );
		
		MyCercle c2 = new MyCercle();
		c2.surface(2);
//		c2.setRayon(1);
		System.out.println(" La surface de C2 : " + c2.surface(1));
		System.out.println(" La surface de C2 : " + new MyCercle(2));
		
		
	}

}