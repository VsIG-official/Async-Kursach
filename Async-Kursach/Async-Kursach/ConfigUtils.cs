﻿namespace Async_Kursach.Fundamentals
{
	/// <summary>
	/// Static class for storing data
	/// OR
	/// Mechanism for accessing the data
	/// </summary>
	internal static class ConfigUtils
	{
		#region Fields

		private static ConfigData configData;

		#endregion Fields

		#region Properties

		/// <summary>
		/// Gets the string for greeting for start application
		/// </summary>
		public static string Greeting
		{
			get { return configData.Greeting; }
		}

		/// <summary>
		/// Gets the string for entering name
		/// </summary>
		public static string EnterName
		{
			get { return configData.EnterName; }
		}

		/// <summary>
		/// Gets the string for entering wrong number
		/// </summary>
		public static string WrongNumber
		{
			get { return configData.WrongNumber; }
		}

		/// <summary>
		/// Gets the string for wrong data
		/// </summary>
		public static string WrongData
		{
			get { return configData.WrongData; }
		}

		/// <summary>
		/// Gets the string for wrong data
		/// </summary>
		public static string NextChoice
		{
			get { return configData.NextChoice; }
		}

		#endregion Properties

		#region PublicMethods

		/// <summary>
		/// Initializes the configuration data by creating the ConfigData object
		/// </summary>
		public static void Initialize()
		{
			configData = new ConfigData();
		}

		#endregion PublicMethods
	}
}
