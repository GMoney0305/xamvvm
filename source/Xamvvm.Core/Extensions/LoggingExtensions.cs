﻿using System;

namespace Xamvvm
{
	/// <summary>
	/// sLogging extensions.
	/// </summary>
	public static class LoggingExtensions
	{
		/// <summary>
		/// Logs the debug.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="message">Message.</param>
		public static void LogDebug(this object sender, string message)
		{
			XamvvmCore.CurrentFactory.Logger.LogDebug(sender, message);
		}

		/// <summary>
		/// Logs the info.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="message">Message.</param>
		public static void LogInfo(this object sender, string message)
		{
			XamvvmCore.CurrentFactory.Logger.LogInfo(sender, message);
		}

		/// <summary>
		/// Logs the error.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="ex">Ex.</param>
		/// <param name="message">Message.</param>
		public static void LogError(this object sender, Exception ex = null, string message = null)
		{
			XamvvmCore.CurrentFactory.Logger.LogError(sender, ex, message);
		}
	}
}