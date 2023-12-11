public class Vehicle {
    private string Model();
    private string Make();
    private string Engine();

    Vehicle(string make, string model, string engine) {
        this.Make = make;
        this.Model = model;
        this.Engine = engine;
    }

    string getMake() {
        return Make;
    }
     string getModel() {
        return Model;
     }

     string getEngine() {
        return Engine;
     }
}
