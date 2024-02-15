public class Car {
        public int Wheels { get; set; }
        public int Speed { get; set; }
        public Person?[] Passengers { get; set; }
        public int MaxNumPassengers { get; set; }
        public Person? Driver { get; set; }
        public int NumAvailSeats { get; private set; }
        public string Name { get; set; }

        public Car(string carName, int wheels) {
            this.Name = carName;
            this.Wheels = wheels;
            this.MaxNumPassengers = 4;
            this.NumAvailSeats = this.MaxNumPassengers;
            this.Passengers = new Person[this.MaxNumPassengers];
        }

        public Car(string carName, int wheels, int maxNumPassengers) {
            this.Name = carName;
            this.Wheels = wheels;
            this.MaxNumPassengers = maxNumPassengers;
            this.NumAvailSeats = this.MaxNumPassengers;
            this.Passengers = new Person[maxNumPassengers];
        }

        public bool AddPassenger(Person person){
            bool addedPerson = false;

            if(person == this.Driver) {
                Console.WriteLine($"{person.FirstName} {person.LastName} is the current Driver of the car and cannot become a passenger until another driver is assigned.");
           
            } else if(this.NumAvailSeats > 0) {
                // if there are seats, check that person 
                // is not already in car
                if(-1 == this.CheckPassenger(person)) {
                    // add if not in car & return true
                    for(int i = 0; i < this.Passengers.Length; i++){
                        if(null == this.Passengers[i]){
                            // open seat
                            this.Passengers[i] = person;
                            this.NumAvailSeats--;
                            addedPerson = true;

                            break;
                        }
                    }
                } else {
                    // person IS in the car
                    // console message & return false
                    Console.WriteLine($"{person.FirstName} {person.LastName} is already in the car."); 
                }

            }
                
            return addedPerson;    
        }

        public void AssignDriver(Person person) {
            // Check if there is a Driver currently
            if(null != this.Driver) {
                // There is currently a Driver, so attempt
                // to add as a passenger
                Person oldDriver = this.Driver;
                this.Driver = null;

                this.AddPassenger(oldDriver);
            }

            // Regardless of if the Driver was able to be added as
            // a passenger, we will be re-assigning the Driver to be the
            // person that was passed to us.
            this.Driver = person;

        }

        public int CheckPassenger(Person person){
            int inCar = -1;
            for(int i = 0; i < this.Passengers.Length; i++){
                if(this.Passengers[i] == person) {
                    inCar = i;
                    break;
                }
            }

            return inCar;
        }

        public void Drive(int speed) {
            if(null != this.Driver) {
                this.Speed = speed;
                Console.WriteLine($"The car is now being driven by {this.Driver.FirstName} at {speed} mph.");

            } else {
                Console.WriteLine("The car cannot be driven without a driver.");
            }
        }

        public Person? RemovePassenger(Person person){
            Person? removedPerson = null;
            int indexOfPassenger = this.CheckPassenger(person);

            if(indexOfPassenger > -1) {
                removedPerson = this.Passengers[indexOfPassenger];
                // Empty the seat
                this.Passengers[indexOfPassenger] = null;
                this.NumAvailSeats++;

            }

            return removedPerson;
        }

        /*
            CAN THIS BENEFIT FROM USING AN INSTANCE VARIABLE?
                - Where would the instance variable be used?

            DO WE NEED THIS METHOD?
        */
        // public int NumAvailSeats() {
        //     int numSeats = 0;
        //     for(int i = 0; i < this.Passengers.Length; i++){
        //         if(null == this.Passengers[i]){
        //             numSeats++;
        //         }
        //     }

        //     return numSeats;
        // }
     
}