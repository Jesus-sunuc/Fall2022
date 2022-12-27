// Map.cs contains the Map class for the HPAir problem.
// Originally written by Garth Sorenson
// 10 Oct 2022
// Eddited by Jesus Sunuc
// 20 Oct 2022

using System;
using System.Collections.Generic;
using System.IO;

namespace ProjCh7
{
    internal class Map : MapInterface
    {
        //List of the names of all cities
        private List<string> _availableCities;
        private List<ListReferenceBased> _flightConnections;

        //Default constructor for map class
        public Map()
        {
            _availableCities = new List<string>();
            _flightConnections = new List<ListReferenceBased>();

        }

        //Method to read in the cities and connections from file
        public void read(string CityFileName, string flightFileName)
        {
            string[] stringCities = File.ReadAllLines(CityFileName);

            foreach (string a in stringCities)
            {
                _availableCities.Add(a);
            }

            string[] flightConnections = File.ReadAllLines(flightFileName);

            foreach (string connection in flightConnections)
            {
                string[] orginDestination = connection.Split(",");

                ListReferenceBased route = new ListReferenceBased();

                for (int i = orginDestination.Length - 1; i >= 0; i--)
                {
                    route.add(0, new City(orginDestination[i].Trim()));
                }

                _flightConnections.Add(route);
            }
        }

        //Method to display flight map
        public void display()
        {
            Console.WriteLine("Available flight Connections:");
            foreach (ListReferenceBased a in _flightConnections)
            {
                Console.WriteLine();

                for (int i = 0; i < a.size(); i++)
                {
                    if (i == a.size() - 1)
                    {
                        Console.Write(a.get(i));
                    }
                    else
                    {
                        Console.Write($"{a.get(i)} ===> ");
                    }
                }

                Console.WriteLine();
                continue;
            }
        }

        //Method that displays all cities adjacent to a specific location
        public void displayAdjacentCities(City aCity)
        {
            Console.WriteLine($"The adjacent cities to {aCity} are:");

            List<string> adjacentcities = new List<string>();

            foreach (ListReferenceBased a in _flightConnections)
            {

                for (int i = 0; i < a.size() - 1; i++)
                {
                    if (aCity.compareTo(a.get(i)))
                    {
                        adjacentcities.Add(a.get(i + 1).ToString());
                    }
                }
            }

            foreach (string a in adjacentcities)
            {
                Console.Write($"{a} ");
            }
        }

        //Method to diplay all the cities adjacent to a location
        public void displayAllCities()
        {
            Console.WriteLine("All the cities available are:");

            foreach (string a in _availableCities)
            {
                Console.Write($"{a}, ");
            }

            Console.WriteLine();
        }

        //Method to mark a city as visites
        public void markVisited(City aCity) => aCity.visited = true;

        //Method that returns next unvisited city of a location
        public City getNextCity(City aCity)
        {
            foreach (ListReferenceBased a in _flightConnections)
            {

                for (int i = 0; i < a.size() - 1; i++)
                {
                    if (aCity.compareTo(a.get(i)))
                    {
                        if (!a.get(i).visited)
                        {
                            return a.get(i + 1);
                        }
                    }
                }
            }

            return null;
        }

        //Method to mark all cities in a flight map as unvisited
        public void unvisitAll()
        {
            foreach (ListReferenceBased a in _flightConnections)
            {
                for (int i = 0; i <= a.size() - 1; i++)
                {
                    a.get(i).visited = false;
                }
            }
        }

        //Method to tell wether or not a location has been visited
        public bool isVisited(City aCity)
        {
            if (aCity.visited)
            {
                return true;
            }

            return false;
        }

        //Method to insert a city next to another one and add it to the flight map
        public void insertAdjacent(City aCity, City adjCity)
        {
            _availableCities.Add(adjCity.ToString());

            foreach (ListReferenceBased a in _flightConnections)
            {

                for (int i = 0; i <= a.size() - 1; i++)
                {
                    if (aCity.compareTo(a.get(i)))
                    {
                        a.add(i+1, adjCity);
                    }
                }
            }
        }
        //Method to tell wether or not a city is served by the ariline
        public bool isServed(City aCity)
        {
            foreach(string a in _availableCities)
            {
                if(aCity.ToString() == a)
                return true;
            }

            return false;
        }

        //Method to tell wether or not there's a path available from one city to another
        public bool isPath(City originCity, City destinationCity)
        {
            // ---------------------------------------------------
            // Determines whether a sequence of flights between two cities
            // exists. Nonrecursive stack version.
            // Precondition: originCity and destinationCity are the origin
            // and destination cities, respectively.
            // Postcondition: Returns true if a sequence of flights exists
            // from originCity to destinationCity, otherwise returns
            // false. Cities visited during the search are marked as
            // visited in the flight map.
            // Implementation notes: Uses a stack for the cities of a
            // potential path. Calls unvisitAll, markVisited, and
            // getNextCity.
            // ---------------------------------------------------
            StackReferenceBased stack = new StackReferenceBased();

            City topCity, nextCity;
            unvisitAll();  // clear marks on all cities

            // push origin city onto stack, mark it visited
            stack.push(originCity);
            markVisited(originCity);

            topCity = (City)(stack.peek());
            while (!stack.isEmpty() &&
                    (!topCity.compareTo(destinationCity)))
            {
                // loop invariant: stack contains a directed path
                // from the origin city at the bottom of the stack
                // to the city at the top of the stack

                // find an unvisited city adjacent to the city on
                // the top of the stack
                nextCity = getNextCity(topCity);

                if (nextCity == null)
                {
                    stack.pop();  // no city found; backtrack
                }
                else
                {                  // visit city
                    stack.push(nextCity);
                    markVisited(nextCity);
                }  // end if
                if (!stack.isEmpty())
                    topCity = (City)stack.peek();
            }  // end while
            if (stack.isEmpty())
            {
                return false;  // no path exists
            }
            else
            {
                return true;   // path exists
            }  // end if*/
        }  // end isPath    
    }
}