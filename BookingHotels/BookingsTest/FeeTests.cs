﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookingHotels;

namespace BookingsTest
{
    [TestClass]
    public class FeeTests
    {
        [TestMethod]
        public void Calculate_FinalPriceForClientRewardRidgewood_ReturnsFeePrice()
        {
            string[] dates = new string[] { "26Mar2009(thur)", "27Mar2009(fri)", "28Mar2009(sat)" }; // 2 weekdays, 1 weekend
            Hotel hotel = new HotelRidgewood(); // 100 weekday, 40 weekend
            Client client = new ClientReward(dates);

            double result = hotel.fee.Calculate(client);

            double expected = 240.0; // 100 + 100 + 40
            
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_FinalPriceForClientRewardBridgewood_ReturnsFeePrice()
        {
            string[] dates = new string[] { "26Mar2009(thur)", "27Mar2009(fri)", "28Mar2009(sat)" }; // 2 weekdays, 1 weekend
            Hotel hotel = new HotelBridgewood(); // 110 weekday, 50 weekend
            Client client = new ClientReward(dates);

            double result = hotel.fee.Calculate(client);

            double expected = 270.0; // 110 + 110 + 50
            
            Assert.AreEqual(expected, result);
        } 
        
        [TestMethod]
        public void Calculate_FinalPriceForClientRewardLakewood_ReturnsFeePrice()
        {
            string[] dates = new string[] { "26Mar2009(thur)", "27Mar2009(fri)", "28Mar2009(sat)" }; // 2 weekdays, 1 weekend
            Hotel hotel = new HotelLakewood(); // 80 weekday, 80 weekend
            Client client = new ClientReward(dates);

            double result = hotel.fee.Calculate(client);

            double expected = 240.0; // 80 + 80 + 80
            
            Assert.AreEqual(expected, result);
        } 
        
        [TestMethod]
        public void Calculate_FinalPriceForClientRegularRidgewood_ReturnsFeePrice()
        {
            string[] dates = new string[] { "26Mar2009(thur)", "27Mar2009(fri)", "28Mar2009(sat)" }; // 2 weekdays, 1 weekend
            Hotel hotel = new HotelRidgewood(); // 220 weekday, 150 weekend
            Client client = new ClientRegular(dates);

            double result = hotel.fee.Calculate(client);

            double expected = 590.0; // 220 + 220 + 150
            
            Assert.AreEqual(expected, result);
        }
        
        [TestMethod]
        public void Calculate_FinalPriceForClientRegularBridgewood_ReturnsFeePrice()
        {
            string[] dates = new string[] { "26Mar2009(thur)", "27Mar2009(fri)", "28Mar2009(sat)" }; // 2 weekdays, 1 weekend
            Hotel hotel = new HotelBridgewood(); // 160 weekday, 60 weekend
            Client client = new ClientRegular(dates);

            double result = hotel.fee.Calculate(client);

            double expected = 380.0; // 160 + 160 + 60
            
            Assert.AreEqual(expected, result);
        }
        
        [TestMethod]
        public void Calculate_FinalPriceForClientRegularLakewood_ReturnsFeePrice()
        {
            string[] dates = new string[] { "26Mar2009(thur)", "27Mar2009(fri)", "28Mar2009(sat)" }; // 2 weekdays, 1 weekend
            Hotel hotel = new HotelLakewood(); // 110 weekday, 90 weekend
            Client client = new ClientRegular(dates);

            double result = hotel.fee.Calculate(client);

            double expected = 310.0; // 110 + 110 + 90
            
            Assert.AreEqual(expected, result);
        }
      
    }
}
