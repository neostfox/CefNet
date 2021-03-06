﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_audio_handler_capi.h
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
	/// Implement this structure to handle audio events.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_audio_handler_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// int (*)(_cef_audio_handler_t* self, _cef_browser_t* browser, cef_audio_parameters_t* params)*
		/// </summary>
		public void* get_audio_parameters;

		/// <summary>
		/// Called on the UI thread to allow configuration of audio stream parameters.
		/// Return true (1) to proceed with audio stream capture, or false (0) to
		/// cancel it. All members of |params| can optionally be configured here, but
		/// they are also pre-filled with some sensible defaults.
		/// </summary>
		[NativeName("get_audio_parameters")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int GetAudioParameters(cef_browser_t* browser, cef_audio_parameters_t* @params);

		/// <summary>
		/// void (*)(_cef_audio_handler_t* self, _cef_browser_t* browser, const cef_audio_parameters_t* params, int channels)*
		/// </summary>
		public void* on_audio_stream_started;

		/// <summary>
		/// Called on a browser audio capture thread when the browser starts streaming
		/// audio. OnAudioSteamStopped will always be called after
		/// OnAudioStreamStarted; both functions may be called multiple times for the
		/// same browser. |params| contains the audio parameters like sample rate and
		/// channel layout. |channels| is the number of channels.
		/// </summary>
		[NativeName("on_audio_stream_started")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void OnAudioStreamStarted(cef_browser_t* browser, [Immutable]cef_audio_parameters_t* @params, int channels);

		/// <summary>
		/// void (*)(_cef_audio_handler_t* self, _cef_browser_t* browser, const float** data, int frames, int64 pts)*
		/// </summary>
		public void* on_audio_stream_packet;

		/// <summary>
		/// Called on the audio stream thread when a PCM packet is received for the
		/// stream. |data| is an array representing the raw PCM data as a floating
		/// point type, i.e. 4-byte value(s). |frames| is the number of frames in the
		/// PCM packet. |pts| is the presentation timestamp (in milliseconds since the
		/// Unix Epoch) and represents the time at which the decompressed packet should
		/// be presented to the user. Based on |frames| and the |channel_layout| value
		/// passed to OnAudioStreamStarted you can calculate the size of the |data|
		/// array in bytes.
		/// </summary>
		[NativeName("on_audio_stream_packet")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void OnAudioStreamPacket(cef_browser_t* browser, [Immutable]float** data, int frames, long pts);

		/// <summary>
		/// void (*)(_cef_audio_handler_t* self, _cef_browser_t* browser)*
		/// </summary>
		public void* on_audio_stream_stopped;

		/// <summary>
		/// Called on the UI thread when the stream has stopped. OnAudioSteamStopped
		/// will always be called after OnAudioStreamStarted; both functions may be
		/// called multiple times for the same stream.
		/// </summary>
		[NativeName("on_audio_stream_stopped")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void OnAudioStreamStopped(cef_browser_t* browser);

		/// <summary>
		/// void (*)(_cef_audio_handler_t* self, _cef_browser_t* browser, const cef_string_t* message)*
		/// </summary>
		public void* on_audio_stream_error;

		/// <summary>
		/// Called on the UI or audio stream thread when an error occurred. During the
		/// stream creation phase this callback will be called on the UI thread while
		/// in the capturing phase it will be called on the audio stream thread. The
		/// stream will be stopped immediately.
		/// </summary>
		[NativeName("on_audio_stream_error")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void OnAudioStreamError(cef_browser_t* browser, [Immutable]cef_string_t* message);
	}
}

