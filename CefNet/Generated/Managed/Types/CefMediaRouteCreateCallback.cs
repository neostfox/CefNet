﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_media_route_create_callback_t.cs
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
	/// Callback structure for cef_media_router_t::CreateRoute. The functions of this
	/// structure will be called on the browser process UI thread.
	/// </summary>
	/// <remarks>
	/// Role: Handler
	/// </remarks>
	public unsafe partial class CefMediaRouteCreateCallback : CefBaseRefCounted<cef_media_route_create_callback_t>, ICefMediaRouteCreateCallbackPrivate
	{
		private static readonly OnMediaRouteCreateFinishedDelegate fnOnMediaRouteCreateFinished = OnMediaRouteCreateFinishedImpl;

		internal static unsafe CefMediaRouteCreateCallback Create(IntPtr instance)
		{
			return new CefMediaRouteCreateCallback((cef_media_route_create_callback_t*)instance);
		}

		public CefMediaRouteCreateCallback()
		{
			cef_media_route_create_callback_t* self = this.NativeInstance;
			self->on_media_route_create_finished = (void*)Marshal.GetFunctionPointerForDelegate(fnOnMediaRouteCreateFinished);
		}

		public CefMediaRouteCreateCallback(cef_media_route_create_callback_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefMediaRouteCreateCallbackPrivate.AvoidOnMediaRouteCreateFinished();

		/// <summary>
		/// Method that will be executed when the route creation has finished. |result|
		/// will be CEF_MRCR_OK if the route creation succeeded. |error| will be a
		/// description of the error if the route creation failed. |route| is the
		/// resulting route, or NULL if the route creation failed.
		/// </summary>
		public unsafe virtual void OnMediaRouteCreateFinished(CefMediaRouteCreateResult result, string error, CefMediaRoute route)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnMediaRouteCreateFinishedDelegate(cef_media_route_create_callback_t* self, CefMediaRouteCreateResult result, cef_string_t* error, cef_media_route_t* route);

		// void (*)(_cef_media_route_create_callback_t* self, cef_media_route_create_result_t result, const cef_string_t* error, _cef_media_route_t* route)*
		private static unsafe void OnMediaRouteCreateFinishedImpl(cef_media_route_create_callback_t* self, CefMediaRouteCreateResult result, cef_string_t* error, cef_media_route_t* route)
		{
			var instance = GetInstance((IntPtr)self) as CefMediaRouteCreateCallback;
			if (instance == null || ((ICefMediaRouteCreateCallbackPrivate)instance).AvoidOnMediaRouteCreateFinished())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)route);
				return;
			}
			instance.OnMediaRouteCreateFinished(result, CefString.Read(error), CefMediaRoute.Wrap(CefMediaRoute.Create, route));
		}
	}
}