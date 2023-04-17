//This problem can be found at: https://leetcode.com/problems/design-parking-system

public class ParkingSystem {

    Dictionary<int, int> spots;
    public ParkingSystem(int big, int medium, int small) {
        spots= new Dictionary<int, int>();
        spots.Add(1,big);
        spots.Add(2,medium);
        spots.Add(3,small);
    }
    
    public bool AddCar(int carType) {
        if(spots[carType]>0){
            spots[carType]--;
            return true;
        }
        return false;
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */
