﻿using System;
using EpisodeClass;
using DescriptionClass;
using System.IO;
using SeasonClass;
using Printer;

namespace TVUtilities
{
	class Program
	{
		static void Main(string[] args)
		{
			string fileName = "shows.tv";
			string outputFileName = "storage.tv";

			IPrinter printer = new ConsolePrinter();
			printer.Print($"Reading data from file {fileName}");

			Episode[] episodes = TvUtilities.LoadEpisodesFromFile(fileName);
			Season season = new Season(1, episodes);

			printer.Print(season.ToString());
			for (int i = 0; i < season.Length; i++)
			{
				season[i].AddView(TvUtilities.GenerateRandomScore());
			}
			printer.Print(season.ToString());

			printer = new FilePrinter(outputFileName);
			printer.Print(season.ToString());
		}
	}
}
