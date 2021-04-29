﻿using NEbml.Core;
using System;

namespace NEbml.Matroska
{
	internal static class ReaderExtensions
	{
		public static void LocateElement(this EbmlReader reader, ulong descriptor)
		{
			while (reader.ReadNext())
			{
				if (reader.ElementId.EncodedValue == descriptor)
				{
					reader.EnterContainer();
					return;
				}
			}

			throw new Exception($"Cannot find descriptor {descriptor}");
		}
	}
}