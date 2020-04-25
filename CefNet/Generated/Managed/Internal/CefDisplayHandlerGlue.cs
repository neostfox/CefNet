﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_display_handler_t.cs
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

namespace CefNet.Internal
{
	sealed partial class CefDisplayHandlerGlue: CefDisplayHandler, ICefDisplayHandlerPrivate
	{
		private WebViewGlue _implementation;

		public CefDisplayHandlerGlue(WebViewGlue impl)
		{
			_implementation = impl;
		}

		bool ICefDisplayHandlerPrivate.AvoidOnAddressChange()
		{
			return _implementation.AvoidOnAddressChange();
		}

		protected internal unsafe override void OnAddressChange(CefBrowser browser, CefFrame frame, string url)
		{
			_implementation.OnAddressChange(browser, frame, url);
		}

		bool ICefDisplayHandlerPrivate.AvoidOnTitleChange()
		{
			return _implementation.AvoidOnTitleChange();
		}

		protected internal unsafe override void OnTitleChange(CefBrowser browser, string title)
		{
			_implementation.OnTitleChange(browser, title);
		}

		bool ICefDisplayHandlerPrivate.AvoidOnFaviconUrlChange()
		{
			return _implementation.AvoidOnFaviconUrlChange();
		}

		protected internal unsafe override void OnFaviconUrlChange(CefBrowser browser, CefStringList iconUrls)
		{
			_implementation.OnFaviconUrlChange(browser, iconUrls);
		}

		bool ICefDisplayHandlerPrivate.AvoidOnFullscreenModeChange()
		{
			return _implementation.AvoidOnFullscreenModeChange();
		}

		protected internal unsafe override void OnFullscreenModeChange(CefBrowser browser, bool fullscreen)
		{
			_implementation.OnFullscreenModeChange(browser, fullscreen);
		}

		bool ICefDisplayHandlerPrivate.AvoidOnTooltip()
		{
			return _implementation.AvoidOnTooltip();
		}

		protected internal unsafe override bool OnTooltip(CefBrowser browser, ref string text)
		{
			return _implementation.OnTooltip(browser, ref text);
		}

		bool ICefDisplayHandlerPrivate.AvoidOnStatusMessage()
		{
			return _implementation.AvoidOnStatusMessage();
		}

		protected internal unsafe override void OnStatusMessage(CefBrowser browser, string value)
		{
			_implementation.OnStatusMessage(browser, value);
		}

		bool ICefDisplayHandlerPrivate.AvoidOnConsoleMessage()
		{
			return _implementation.AvoidOnConsoleMessage();
		}

		protected internal unsafe override bool OnConsoleMessage(CefBrowser browser, CefLogSeverity level, string message, string source, int line)
		{
			return _implementation.OnConsoleMessage(browser, level, message, source, line);
		}

		bool ICefDisplayHandlerPrivate.AvoidOnAutoResize()
		{
			return _implementation.AvoidOnAutoResize();
		}

		protected internal unsafe override bool OnAutoResize(CefBrowser browser, CefSize newSize)
		{
			return _implementation.OnAutoResize(browser, newSize);
		}

		bool ICefDisplayHandlerPrivate.AvoidOnLoadingProgressChange()
		{
			return _implementation.AvoidOnLoadingProgressChange();
		}

		protected internal unsafe override void OnLoadingProgressChange(CefBrowser browser, double progress)
		{
			_implementation.OnLoadingProgressChange(browser, progress);
		}

	}
}
