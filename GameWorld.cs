using System.Collections;
using System.Collections.Generic;
using System;

namespace FinalGame
{
    public class GameWorld
    {
        static private GameWorld _instance;
        static public GameWorld Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GameWorld();
                return _instance;
            }
        }

        private GameWorld()
        {
            _entrance = createWorld();
        }

        private Room _entrance;
        public Room Entrance { get { return _entrance; } }
        public Room createWorld()
        {
            Room outside = new Room("outside the mall");
            Room foodCourt = new Room("in the food court");
            Room F21 = new Room("in Forever21");
            Room GameStop = new Room("in GameStop");
            Room Apple = new Room("in the Apple store");
            Room Champs = new Room("in Champs");
            Room PetStore = new Room("in Pet Store");
            Room SPA = new Room("in the Spa");
            Room Aeropostale = new Room("in Aeropostal");

            outside.setExit("foodcourt", foodCourt);

            foodCourt.setExit("outside", outside);
            foodCourt.setExit("F21", F21);
            foodCourt.setExit("GameStop", GameStop);
            foodCourt.setExit("Apple", Apple);
            foodCourt.setExit("Pet Store",PetStore);
            foodCourt.setExit("Champs",Champs);
            foodCourt.setExit("SPA", SPA);
            foodCourt.setExit("Aeropostale", Aeropostale);           

            F21.setExit("foodcourt", foodCourt);

            GameStop.setExit("foodcourt", foodCourt);

            Apple.setExit("foodcourt", foodCourt);

            Champs.setExit("foodcourt", foodCourt);

            PetStore.setExit("foodcourt", foodCourt);

            Aeropostale.setExit("foodcourt", foodCourt);

            SPA.setExit("foodcourt", foodCourt);

            return outside;
        }
    }
}
