﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_media_router_capi.h
// --------------------------------------------------------------------------------------------﻿
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
// --------------------------------------------------------------------------------------------

#pragma warning disable 0169, 1591, 1573

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using CefNet.WinApi;

namespace CefNet.CApi
{
	/// <summary>
	/// Callback structure for cef_media_sink_t::GetDeviceInfo. The functions of this
	/// structure will be called on the browser process UI thread.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_media_sink_device_info_callback_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// void (*)(_cef_media_sink_device_info_callback_t* self, const const _cef_media_sink_device_info_t* device_info)*
		/// </summary>
		public void* on_media_sink_device_info;

		/// <summary>
		/// Method that will be executed asyncronously once device information has been
		/// retrieved.
		/// </summary>
		[NativeName("on_media_sink_device_info")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void OnMediaSinkDeviceInfo([Immutable]cef_media_sink_device_info_t* device_info);
	}
}

