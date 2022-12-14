using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Dijkstra
{
    public class DistOriginal
    {
        public double cost;
        public int parentLocation;
        public DistOriginal(int pl, double c)
        {
            cost = c; parentLocation = pl;
        }
    }

    public class Location
    {
        public string name;
        public bool isInWay;
        public Location(string _name) { name = _name; isInWay = false; }
    }
    public class Graph
    {
        public Location[] LocationList;
        public DistOriginal[] sWay;
        public double[,] adjMaW;
        public string[] inFile_location = File.ReadAllLines(@"locations.txt");
        public string[] inFile_cost = File.ReadAllLines(@"cost.txt");
        public int nLocations;
        public double infinity = 1000000;
        
          
        int nWay; 
        int currentLocation; 
        double startToCurrent;
        int max_locations = 200;
        
        public Graph()
        {
            LocationList = new Location[max_locations];
            adjMaW = new double[max_locations, max_locations];
            nLocations = 0; nWay = 0;
            for (int j = 0; j <= max_locations - 1; j++)
                for (int k = 0; k <= max_locations - 1; k++)
                    adjMaW[j, k] = infinity;
            sWay = new DistOriginal[max_locations];

        }
        public void AddLocation()
        {
            string[] inFile = File.ReadAllLines(@"locations.txt");

            foreach (string name in inFile)
            {
                LocationList[nLocations] = new Location(name);
                nLocations++;
            }
        }

        public double getNumber(string str)
        {
            double k = 0;
            if (str.IndexOf('.') < 0)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    k += ((int)str[i] - 48) * (int)Math.Pow(10, str.Length - i - 1);
                }
                return k;
            }


            for (int i = 0; i < str.IndexOf('.'); i++)
            {
                k += ((int)str[i] - 48) * Math.Pow(10, str.IndexOf('.') - i - 1);
            }
            for (int i = str.IndexOf('.') + 1; i < str.Length; i++)
            {
                k += ((int)str[i] - 48) / Math.Pow(10, i - str.IndexOf('.'));
            }
            return k;

        }
        public void AddCost()
        {
            string[] inFile = File.ReadAllLines(@"cost.txt");
            foreach (string Cost in inFile)
            {
                string[] cos = Cost.Split(' ');
                int location0 = (int)getNumber(cos[0]);
                int location1 = (int)getNumber(cos[1]);
                double cost = getNumber(cos[2]);
                adjMaW[location0, location1] = cost;
                adjMaW[location1, location0] = cost;
            }

        }
        public void Way(ref List<int> way, int startWay, int stopWay)
        {
            if (startWay != stopWay)
            {
                LocationList[startWay].isInWay = true;
                nWay = 1;
                for (int j = 0; j <= nLocations; j++)
                {
                    double tempDist = adjMaW[startWay, j];
                    sWay[j] = new DistOriginal(startWay, tempDist);
                }
                while (nWay < nLocations)
                {
                    int indexMin = GetMin();
                    currentLocation = indexMin;
                    startToCurrent = sWay[indexMin].cost;
                    LocationList[currentLocation].isInWay = true;
                    if (currentLocation == stopWay)
                        break;
                    nWay++;
                    AdjustShortWay();
                }
                way = DisplayWays(startWay, stopWay);
                
                nWay = 0;
                for (int j = 0; j <= nLocations - 1; j++)
                    LocationList[j].isInWay = false;
            }
        }
        public int GetMin()
        {
            double minDist = infinity;
            int indexMin = 0;
            for (int j = 0; j <= nLocations - 1; j++)
                if (!(LocationList[j].isInWay) && sWay[j].cost < minDist)
                {
                    minDist = sWay[j].cost; indexMin = j;
                }
            return indexMin;
        }
        public void AdjustShortWay()
        {
            int column = 0;
            while (column < nLocations)
            {
                if (LocationList[column].isInWay) column++;
                else
                {
                    double currentToFring = adjMaW[currentLocation, column];
                    double startToFringe = startToCurrent + currentToFring;
                    double sWayDist = sWay[column].cost;
                    if (startToFringe < sWayDist)
                    {
                        sWay[column].parentLocation = currentLocation;
                        sWay[column].cost = startToFringe;
                    }
                    column++;
                }
            }
        }
        public List<int> DisplayWays(int startWay, int stopWay)
        {
            List<int> Way = new List<int>();
            if (sWay[stopWay].cost != infinity)
            {
                int m = stopWay;
                Way.Add(m);
                if (m != sWay[m].parentLocation)
                    m = sWay[m].parentLocation;
                else
                    m = -1;
                while (m > -1)
                {
                    Way.Add(m);
                    if (m != sWay[m].parentLocation)
                        m = sWay[m].parentLocation;
                    else
                        m = -1;
                }
            }
            return Way;
        }
    }
}