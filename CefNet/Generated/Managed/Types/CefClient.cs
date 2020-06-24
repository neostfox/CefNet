﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_client_t.cs
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
	/// Implement this structure to provide handler implementations.
	/// </summary>
	/// <remarks>
	/// Role: Handler
	/// </remarks>
	public unsafe partial class CefClient : CefBaseRefCounted<cef_client_t>, ICefClientPrivate
	{
		private static readonly GetAudioHandlerDelegate fnGetAudioHandler = GetAudioHandlerImpl;

		private static readonly GetContextMenuHandlerDelegate fnGetContextMenuHandler = GetContextMenuHandlerImpl;

		private static readonly GetDialogHandlerDelegate fnGetDialogHandler = GetDialogHandlerImpl;

		private static readonly GetDisplayHandlerDelegate fnGetDisplayHandler = GetDisplayHandlerImpl;

		private static readonly GetDownloadHandlerDelegate fnGetDownloadHandler = GetDownloadHandlerImpl;

		private static readonly GetDragHandlerDelegate fnGetDragHandler = GetDragHandlerImpl;

		private static readonly GetFindHandlerDelegate fnGetFindHandler = GetFindHandlerImpl;

		private static readonly GetFocusHandlerDelegate fnGetFocusHandler = GetFocusHandlerImpl;

		private static readonly GetJSDialogHandlerDelegate fnGetJSDialogHandler = GetJSDialogHandlerImpl;

		private static readonly GetKeyboardHandlerDelegate fnGetKeyboardHandler = GetKeyboardHandlerImpl;

		private static readonly GetLifeSpanHandlerDelegate fnGetLifeSpanHandler = GetLifeSpanHandlerImpl;

		private static readonly GetLoadHandlerDelegate fnGetLoadHandler = GetLoadHandlerImpl;

		private static readonly GetRenderHandlerDelegate fnGetRenderHandler = GetRenderHandlerImpl;

		private static readonly GetRequestHandlerDelegate fnGetRequestHandler = GetRequestHandlerImpl;

		private static readonly OnProcessMessageReceivedDelegate fnOnProcessMessageReceived = OnProcessMessageReceivedImpl;

		internal static unsafe CefClient Create(IntPtr instance)
		{
			return new CefClient((cef_client_t*)instance);
		}

		public CefClient()
		{
			cef_client_t* self = this.NativeInstance;
			self->get_audio_handler = (void*)Marshal.GetFunctionPointerForDelegate(fnGetAudioHandler);
			self->get_context_menu_handler = (void*)Marshal.GetFunctionPointerForDelegate(fnGetContextMenuHandler);
			self->get_dialog_handler = (void*)Marshal.GetFunctionPointerForDelegate(fnGetDialogHandler);
			self->get_display_handler = (void*)Marshal.GetFunctionPointerForDelegate(fnGetDisplayHandler);
			self->get_download_handler = (void*)Marshal.GetFunctionPointerForDelegate(fnGetDownloadHandler);
			self->get_drag_handler = (void*)Marshal.GetFunctionPointerForDelegate(fnGetDragHandler);
			self->get_find_handler = (void*)Marshal.GetFunctionPointerForDelegate(fnGetFindHandler);
			self->get_focus_handler = (void*)Marshal.GetFunctionPointerForDelegate(fnGetFocusHandler);
			self->get_jsdialog_handler = (void*)Marshal.GetFunctionPointerForDelegate(fnGetJSDialogHandler);
			self->get_keyboard_handler = (void*)Marshal.GetFunctionPointerForDelegate(fnGetKeyboardHandler);
			self->get_life_span_handler = (void*)Marshal.GetFunctionPointerForDelegate(fnGetLifeSpanHandler);
			self->get_load_handler = (void*)Marshal.GetFunctionPointerForDelegate(fnGetLoadHandler);
			self->get_render_handler = (void*)Marshal.GetFunctionPointerForDelegate(fnGetRenderHandler);
			self->get_request_handler = (void*)Marshal.GetFunctionPointerForDelegate(fnGetRequestHandler);
			self->on_process_message_received = (void*)Marshal.GetFunctionPointerForDelegate(fnOnProcessMessageReceived);
		}

		public CefClient(cef_client_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		/// <summary>
		/// Return the handler for audio rendering events.
		/// </summary>
		protected internal unsafe virtual CefAudioHandler GetAudioHandler()
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate cef_audio_handler_t* GetAudioHandlerDelegate(cef_client_t* self);

		// _cef_audio_handler_t* (*)(_cef_client_t* self)*
		private static unsafe cef_audio_handler_t* GetAudioHandlerImpl(cef_client_t* self)
		{
			var instance = GetInstance((IntPtr)self) as CefClient;
			if (instance == null)
			{
				return default;
			}
			CefAudioHandler rv = instance.GetAudioHandler();
			if (rv == null)
				return null;
			return (rv != null) ? rv.GetNativeInstance() : null;
		}

		/// <summary>
		/// Return the handler for context menus. If no handler is provided the default
		/// implementation will be used.
		/// </summary>
		protected internal unsafe virtual CefContextMenuHandler GetContextMenuHandler()
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate cef_context_menu_handler_t* GetContextMenuHandlerDelegate(cef_client_t* self);

		// _cef_context_menu_handler_t* (*)(_cef_client_t* self)*
		private static unsafe cef_context_menu_handler_t* GetContextMenuHandlerImpl(cef_client_t* self)
		{
			var instance = GetInstance((IntPtr)self) as CefClient;
			if (instance == null)
			{
				return default;
			}
			CefContextMenuHandler rv = instance.GetContextMenuHandler();
			if (rv == null)
				return null;
			return (rv != null) ? rv.GetNativeInstance() : null;
		}

		/// <summary>
		/// Return the handler for dialogs. If no handler is provided the default
		/// implementation will be used.
		/// </summary>
		protected internal unsafe virtual CefDialogHandler GetDialogHandler()
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate cef_dialog_handler_t* GetDialogHandlerDelegate(cef_client_t* self);

		// _cef_dialog_handler_t* (*)(_cef_client_t* self)*
		private static unsafe cef_dialog_handler_t* GetDialogHandlerImpl(cef_client_t* self)
		{
			var instance = GetInstance((IntPtr)self) as CefClient;
			if (instance == null)
			{
				return default;
			}
			CefDialogHandler rv = instance.GetDialogHandler();
			if (rv == null)
				return null;
			return (rv != null) ? rv.GetNativeInstance() : null;
		}

		/// <summary>
		/// Return the handler for browser display state events.
		/// </summary>
		protected internal unsafe virtual CefDisplayHandler GetDisplayHandler()
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate cef_display_handler_t* GetDisplayHandlerDelegate(cef_client_t* self);

		// _cef_display_handler_t* (*)(_cef_client_t* self)*
		private static unsafe cef_display_handler_t* GetDisplayHandlerImpl(cef_client_t* self)
		{
			var instance = GetInstance((IntPtr)self) as CefClient;
			if (instance == null)
			{
				return default;
			}
			CefDisplayHandler rv = instance.GetDisplayHandler();
			if (rv == null)
				return null;
			return (rv != null) ? rv.GetNativeInstance() : null;
		}

		/// <summary>
		/// Return the handler for download events. If no handler is returned downloads
		/// will not be allowed.
		/// </summary>
		protected internal unsafe virtual CefDownloadHandler GetDownloadHandler()
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate cef_download_handler_t* GetDownloadHandlerDelegate(cef_client_t* self);

		// _cef_download_handler_t* (*)(_cef_client_t* self)*
		private static unsafe cef_download_handler_t* GetDownloadHandlerImpl(cef_client_t* self)
		{
			var instance = GetInstance((IntPtr)self) as CefClient;
			if (instance == null)
			{
				return default;
			}
			CefDownloadHandler rv = instance.GetDownloadHandler();
			if (rv == null)
				return null;
			return (rv != null) ? rv.GetNativeInstance() : null;
		}

		/// <summary>
		/// Return the handler for drag events.
		/// </summary>
		protected internal unsafe virtual CefDragHandler GetDragHandler()
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate cef_drag_handler_t* GetDragHandlerDelegate(cef_client_t* self);

		// _cef_drag_handler_t* (*)(_cef_client_t* self)*
		private static unsafe cef_drag_handler_t* GetDragHandlerImpl(cef_client_t* self)
		{
			var instance = GetInstance((IntPtr)self) as CefClient;
			if (instance == null)
			{
				return default;
			}
			CefDragHandler rv = instance.GetDragHandler();
			if (rv == null)
				return null;
			return (rv != null) ? rv.GetNativeInstance() : null;
		}

		/// <summary>
		/// Return the handler for find result events.
		/// </summary>
		protected internal unsafe virtual CefFindHandler GetFindHandler()
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate cef_find_handler_t* GetFindHandlerDelegate(cef_client_t* self);

		// _cef_find_handler_t* (*)(_cef_client_t* self)*
		private static unsafe cef_find_handler_t* GetFindHandlerImpl(cef_client_t* self)
		{
			var instance = GetInstance((IntPtr)self) as CefClient;
			if (instance == null)
			{
				return default;
			}
			CefFindHandler rv = instance.GetFindHandler();
			if (rv == null)
				return null;
			return (rv != null) ? rv.GetNativeInstance() : null;
		}

		/// <summary>
		/// Return the handler for focus events.
		/// </summary>
		protected internal unsafe virtual CefFocusHandler GetFocusHandler()
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate cef_focus_handler_t* GetFocusHandlerDelegate(cef_client_t* self);

		// _cef_focus_handler_t* (*)(_cef_client_t* self)*
		private static unsafe cef_focus_handler_t* GetFocusHandlerImpl(cef_client_t* self)
		{
			var instance = GetInstance((IntPtr)self) as CefClient;
			if (instance == null)
			{
				return default;
			}
			CefFocusHandler rv = instance.GetFocusHandler();
			if (rv == null)
				return null;
			return (rv != null) ? rv.GetNativeInstance() : null;
		}

		/// <summary>
		/// Return the handler for JavaScript dialogs. If no handler is provided the
		/// default implementation will be used.
		/// </summary>
		protected internal unsafe virtual CefJSDialogHandler GetJSDialogHandler()
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate cef_jsdialog_handler_t* GetJSDialogHandlerDelegate(cef_client_t* self);

		// _cef_jsdialog_handler_t* (*)(_cef_client_t* self)*
		private static unsafe cef_jsdialog_handler_t* GetJSDialogHandlerImpl(cef_client_t* self)
		{
			var instance = GetInstance((IntPtr)self) as CefClient;
			if (instance == null)
			{
				return default;
			}
			CefJSDialogHandler rv = instance.GetJSDialogHandler();
			if (rv == null)
				return null;
			return (rv != null) ? rv.GetNativeInstance() : null;
		}

		/// <summary>
		/// Return the handler for keyboard events.
		/// </summary>
		protected internal unsafe virtual CefKeyboardHandler GetKeyboardHandler()
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate cef_keyboard_handler_t* GetKeyboardHandlerDelegate(cef_client_t* self);

		// _cef_keyboard_handler_t* (*)(_cef_client_t* self)*
		private static unsafe cef_keyboard_handler_t* GetKeyboardHandlerImpl(cef_client_t* self)
		{
			var instance = GetInstance((IntPtr)self) as CefClient;
			if (instance == null)
			{
				return default;
			}
			CefKeyboardHandler rv = instance.GetKeyboardHandler();
			if (rv == null)
				return null;
			return (rv != null) ? rv.GetNativeInstance() : null;
		}

		/// <summary>
		/// Return the handler for browser life span events.
		/// </summary>
		protected internal unsafe virtual CefLifeSpanHandler GetLifeSpanHandler()
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate cef_life_span_handler_t* GetLifeSpanHandlerDelegate(cef_client_t* self);

		// _cef_life_span_handler_t* (*)(_cef_client_t* self)*
		private static unsafe cef_life_span_handler_t* GetLifeSpanHandlerImpl(cef_client_t* self)
		{
			var instance = GetInstance((IntPtr)self) as CefClient;
			if (instance == null)
			{
				return default;
			}
			CefLifeSpanHandler rv = instance.GetLifeSpanHandler();
			if (rv == null)
				return null;
			return (rv != null) ? rv.GetNativeInstance() : null;
		}

		/// <summary>
		/// Return the handler for browser load status events.
		/// </summary>
		protected internal unsafe virtual CefLoadHandler GetLoadHandler()
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate cef_load_handler_t* GetLoadHandlerDelegate(cef_client_t* self);

		// _cef_load_handler_t* (*)(_cef_client_t* self)*
		private static unsafe cef_load_handler_t* GetLoadHandlerImpl(cef_client_t* self)
		{
			var instance = GetInstance((IntPtr)self) as CefClient;
			if (instance == null)
			{
				return default;
			}
			CefLoadHandler rv = instance.GetLoadHandler();
			if (rv == null)
				return null;
			return (rv != null) ? rv.GetNativeInstance() : null;
		}

		/// <summary>
		/// Return the handler for off-screen rendering events.
		/// </summary>
		protected internal unsafe virtual CefRenderHandler GetRenderHandler()
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate cef_render_handler_t* GetRenderHandlerDelegate(cef_client_t* self);

		// _cef_render_handler_t* (*)(_cef_client_t* self)*
		private static unsafe cef_render_handler_t* GetRenderHandlerImpl(cef_client_t* self)
		{
			var instance = GetInstance((IntPtr)self) as CefClient;
			if (instance == null)
			{
				return default;
			}
			CefRenderHandler rv = instance.GetRenderHandler();
			if (rv == null)
				return null;
			return (rv != null) ? rv.GetNativeInstance() : null;
		}

		/// <summary>
		/// Return the handler for browser request events.
		/// </summary>
		protected internal unsafe virtual CefRequestHandler GetRequestHandler()
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate cef_request_handler_t* GetRequestHandlerDelegate(cef_client_t* self);

		// _cef_request_handler_t* (*)(_cef_client_t* self)*
		private static unsafe cef_request_handler_t* GetRequestHandlerImpl(cef_client_t* self)
		{
			var instance = GetInstance((IntPtr)self) as CefClient;
			if (instance == null)
			{
				return default;
			}
			CefRequestHandler rv = instance.GetRequestHandler();
			if (rv == null)
				return null;
			return (rv != null) ? rv.GetNativeInstance() : null;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefClientPrivate.AvoidOnProcessMessageReceived();

		/// <summary>
		/// Called when a new message is received from a different process. Return true
		/// (1) if the message was handled or false (0) otherwise. Do not keep a
		/// reference to or attempt to access the message outside of this callback.
		/// </summary>
		protected internal unsafe virtual bool OnProcessMessageReceived(CefBrowser browser, CefFrame frame, CefProcessId sourceProcess, CefProcessMessage message)
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int OnProcessMessageReceivedDelegate(cef_client_t* self, cef_browser_t* browser, cef_frame_t* frame, CefProcessId source_process, cef_process_message_t* message);

		// int (*)(_cef_client_t* self, _cef_browser_t* browser, _cef_frame_t* frame, cef_process_id_t source_process, _cef_process_message_t* message)*
		private static unsafe int OnProcessMessageReceivedImpl(cef_client_t* self, cef_browser_t* browser, cef_frame_t* frame, CefProcessId source_process, cef_process_message_t* message)
		{
			var instance = GetInstance((IntPtr)self) as CefClient;
			if (instance == null || ((ICefClientPrivate)instance).AvoidOnProcessMessageReceived())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)frame);
				ReleaseIfNonNull((cef_base_ref_counted_t*)message);
				return default;
			}
			return instance.OnProcessMessageReceived(CefBrowser.Wrap(CefBrowser.Create, browser), CefFrame.Wrap(CefFrame.Create, frame), source_process, CefProcessMessage.Wrap(CefProcessMessage.Create, message)) ? 1 : 0;
		}
	}
}
