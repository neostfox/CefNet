﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_dialog_handler_t.cs
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
	/// Implement this structure to handle dialog events. The functions of this
	/// structure will be called on the browser process UI thread.
	/// </summary>
	/// <remarks>
	/// Role: Handler
	/// </remarks>
	public unsafe partial class CefDialogHandler : CefBaseRefCounted<cef_dialog_handler_t>, ICefDialogHandlerPrivate
	{
		private static readonly OnFileDialogDelegate fnOnFileDialog = OnFileDialogImpl;

		internal static unsafe CefDialogHandler Create(IntPtr instance)
		{
			return new CefDialogHandler((cef_dialog_handler_t*)instance);
		}

		public CefDialogHandler()
		{
			cef_dialog_handler_t* self = this.NativeInstance;
			self->on_file_dialog = (void*)Marshal.GetFunctionPointerForDelegate(fnOnFileDialog);
		}

		public CefDialogHandler(cef_dialog_handler_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefDialogHandlerPrivate.AvoidOnFileDialog();

		/// <summary>
		/// Called to run a file chooser dialog. |mode| represents the type of dialog
		/// to display. |title| to the title to be used for the dialog and may be NULL
		/// to show the default title (&quot;Open&quot; or &quot;Save&quot; depending on the mode).
		/// |default_file_path| is the path with optional directory and/or file name
		/// component that should be initially selected in the dialog. |accept_filters|
		/// are used to restrict the selectable file types and may any combination of
		/// (a) valid lower-cased MIME types (e.g. &quot;text/*&quot; or &quot;image/*&quot;), (b)
		/// individual file extensions (e.g. &quot;.txt&quot; or &quot;.png&quot;), or (c) combined
		/// description and file extension delimited using &quot;|&quot; and &quot;;&quot; (e.g. &quot;Image
		/// Types|.png;.gif;.jpg&quot;). |selected_accept_filter| is the 0-based index of
		/// the filter that should be selected by default. To display a custom dialog
		/// return true (1) and execute |callback| either inline or at a later time. To
		/// display the default dialog return false (0).
		/// </summary>
		protected internal unsafe virtual bool OnFileDialog(CefBrowser browser, CefFileDialogMode mode, string title, string defaultFilePath, CefStringList acceptFilters, bool selectedAcceptFilter, CefFileDialogCallback callback)
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int OnFileDialogDelegate(cef_dialog_handler_t* self, cef_browser_t* browser, CefFileDialogMode mode, cef_string_t* title, cef_string_t* default_file_path, cef_string_list_t accept_filters, int selected_accept_filter, cef_file_dialog_callback_t* callback);

		// int (*)(_cef_dialog_handler_t* self, _cef_browser_t* browser, cef_file_dialog_mode_t mode, const cef_string_t* title, const cef_string_t* default_file_path, cef_string_list_t accept_filters, int selected_accept_filter, _cef_file_dialog_callback_t* callback)*
		private static unsafe int OnFileDialogImpl(cef_dialog_handler_t* self, cef_browser_t* browser, CefFileDialogMode mode, cef_string_t* title, cef_string_t* default_file_path, cef_string_list_t accept_filters, int selected_accept_filter, cef_file_dialog_callback_t* callback)
		{
			var instance = GetInstance((IntPtr)self) as CefDialogHandler;
			if (instance == null || ((ICefDialogHandlerPrivate)instance).AvoidOnFileDialog())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)callback);
				return default;
			}
			return instance.OnFileDialog(CefBrowser.Wrap(CefBrowser.Create, browser), mode, CefString.Read(title), CefString.Read(default_file_path), CefStringList.Wrap(accept_filters), selected_accept_filter != 0, CefFileDialogCallback.Wrap(CefFileDialogCallback.Create, callback)) ? 1 : 0;
		}
	}
}
