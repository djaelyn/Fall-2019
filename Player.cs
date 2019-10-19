using System.Collections;
using System.Collections.Generic;
using System;

namespace FinalGame
{
    public class Player
    {
        // Don't know if this is the right place for this. But this currently works! 
        private Stack<Room> _visitedRooms = null;
        public Stack<Room> visitedRooms
        {
            get { return _visitedRooms; }
            //set { _visitedRooms = value; }
        }
        // 

        private Room _currentRoom = null;
        public Room currentRoom
        {
            get { return _currentRoom; }
            set { _currentRoom = value; }
        }


        public Player(Room room)
        {
            _currentRoom = room;
            _visitedRooms = new Stack<Room>();
        }

        public void walkTo(string direction)
        {
            Room nextRoom = this._currentRoom.getExit(direction);
            if (nextRoom != null)
            {
                visitedRooms.Push(this._currentRoom);
                this._currentRoom = nextRoom;
                this.outputMessage("\n" + this._currentRoom.description());           
            }
            else
            {
                this.outputMessage("\nThere is no door on" + direction);
            }
        }

        // Don't know if this is right
        public void backtrack()
        {
            if (visitedRooms.Count > 0)
            {
                this._currentRoom = visitedRooms.Pop();
                this.outputMessage("\n" + this._currentRoom.description());
            }
            else
            {
                this.outputMessage("\n You're already back where you began!\n" + this.currentRoom.description());
            }
        }
        //

        public void outputMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}