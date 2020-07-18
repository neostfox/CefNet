﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_media_sink_device_info_t.cs
// --------------------------------------------------------------------------------------------﻿
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
// --------------------------------------------------------------------------------------------

#pragma warning disable 0169, 1591, 1573

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using CefNet.WinApi;
using CefNet.CApi;
using CefNet.Internal;

namespace CefNet
{
	/// <summary>
	/// Device information for a MediaSink object.
	/// </summary>
	/// <remarks>
	/// Role: Proxy
	/// </remarks>
	public unsafe partial struct CefMediaSinkDeviceInfo : IDisposable
	{
		private cef_media_sink_device_info_t _instance;

		public string IpAddress
		{
			get
			{
				fixed (cef_string_t* s = &_instance.ip_address)
				{
					return CefString.Read(s);
				}
			}
			set
			{
				fixed (cef_string_t* s = &_instance.ip_address)
				{
					CefString.Replace(s, value);
				}
			}
		}

		public int Port
		{
			get
			{
				return _instance.port;
			}
			set
			{
				_instance.port = value;
			}
		}

		public string ModelName
		{
			get
			{
				fixed (cef_string_t* s = &_instance.model_name)
				{
					return CefString.Read(s);
				}
			}
			set
			{
				fixed (cef_string_t* s = &_instance.model_name)
				{
					CefString.Replace(s, value);
				}
			}
		}

		public void Dispose()
		{
			IpAddress = null;
			ModelName = null;
		}

		public static implicit operator CefMediaSinkDeviceInfo(cef_media_sink_device_info_t instance)
		{
			return new CefMediaSinkDeviceInfo { _instance = instance };
		}

		public static implicit operator cef_media_sink_device_info_t(CefMediaSinkDeviceInfo instance)
		{
			return instance._instance;
		}
	}
}