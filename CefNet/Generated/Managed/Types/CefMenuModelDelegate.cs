﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_menu_model_delegate_t.cs
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
	/// Implement this structure to handle menu model events. The functions of this
	/// structure will be called on the browser process UI thread unless otherwise
	/// indicated.
	/// </summary>
	/// <remarks>
	/// Role: Handler
	/// </remarks>
	public unsafe partial class CefMenuModelDelegate : CefBaseRefCounted<cef_menu_model_delegate_t>, ICefMenuModelDelegatePrivate
	{
		private static readonly ExecuteCommandDelegate fnExecuteCommand = ExecuteCommandImpl;

		private static readonly MouseOutsideMenuDelegate fnMouseOutsideMenu = MouseOutsideMenuImpl;

		private static readonly UnhandledOpenSubmenuDelegate fnUnhandledOpenSubmenu = UnhandledOpenSubmenuImpl;

		private static readonly UnhandledCloseSubmenuDelegate fnUnhandledCloseSubmenu = UnhandledCloseSubmenuImpl;

		private static readonly MenuWillShowDelegate fnMenuWillShow = MenuWillShowImpl;

		private static readonly MenuClosedDelegate fnMenuClosed = MenuClosedImpl;

		private static readonly FormatLabelDelegate fnFormatLabel = FormatLabelImpl;

		internal static unsafe CefMenuModelDelegate Create(IntPtr instance)
		{
			return new CefMenuModelDelegate((cef_menu_model_delegate_t*)instance);
		}

		public CefMenuModelDelegate()
		{
			cef_menu_model_delegate_t* self = this.NativeInstance;
			self->execute_command = (void*)Marshal.GetFunctionPointerForDelegate(fnExecuteCommand);
			self->mouse_outside_menu = (void*)Marshal.GetFunctionPointerForDelegate(fnMouseOutsideMenu);
			self->unhandled_open_submenu = (void*)Marshal.GetFunctionPointerForDelegate(fnUnhandledOpenSubmenu);
			self->unhandled_close_submenu = (void*)Marshal.GetFunctionPointerForDelegate(fnUnhandledCloseSubmenu);
			self->menu_will_show = (void*)Marshal.GetFunctionPointerForDelegate(fnMenuWillShow);
			self->menu_closed = (void*)Marshal.GetFunctionPointerForDelegate(fnMenuClosed);
			self->format_label = (void*)Marshal.GetFunctionPointerForDelegate(fnFormatLabel);
		}

		public CefMenuModelDelegate(cef_menu_model_delegate_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefMenuModelDelegatePrivate.AvoidExecuteCommand();

		/// <summary>
		/// Perform the action associated with the specified |command_id| and optional
		/// |event_flags|.
		/// </summary>
		protected internal unsafe virtual void ExecuteCommand(CefMenuModel menuModel, int commandId, CefEventFlags eventFlags)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void ExecuteCommandDelegate(cef_menu_model_delegate_t* self, cef_menu_model_t* menu_model, int command_id, CefEventFlags event_flags);

		// void (*)(_cef_menu_model_delegate_t* self, _cef_menu_model_t* menu_model, int command_id, cef_event_flags_t event_flags)*
		private static unsafe void ExecuteCommandImpl(cef_menu_model_delegate_t* self, cef_menu_model_t* menu_model, int command_id, CefEventFlags event_flags)
		{
			var instance = GetInstance((IntPtr)self) as CefMenuModelDelegate;
			if (instance == null || ((ICefMenuModelDelegatePrivate)instance).AvoidExecuteCommand())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)menu_model);
				return;
			}
			instance.ExecuteCommand(CefMenuModel.Wrap(CefMenuModel.Create, menu_model), command_id, event_flags);
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefMenuModelDelegatePrivate.AvoidMouseOutsideMenu();

		/// <summary>
		/// Called when the user moves the mouse outside the menu and over the owning
		/// window.
		/// </summary>
		protected internal unsafe virtual void MouseOutsideMenu(CefMenuModel menuModel, CefPoint screenPoint)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void MouseOutsideMenuDelegate(cef_menu_model_delegate_t* self, cef_menu_model_t* menu_model, cef_point_t* screen_point);

		// void (*)(_cef_menu_model_delegate_t* self, _cef_menu_model_t* menu_model, const cef_point_t* screen_point)*
		private static unsafe void MouseOutsideMenuImpl(cef_menu_model_delegate_t* self, cef_menu_model_t* menu_model, cef_point_t* screen_point)
		{
			var instance = GetInstance((IntPtr)self) as CefMenuModelDelegate;
			if (instance == null || ((ICefMenuModelDelegatePrivate)instance).AvoidMouseOutsideMenu())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)menu_model);
				return;
			}
			instance.MouseOutsideMenu(CefMenuModel.Wrap(CefMenuModel.Create, menu_model), *(CefPoint*)screen_point);
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefMenuModelDelegatePrivate.AvoidUnhandledOpenSubmenu();

		/// <summary>
		/// Called on unhandled open submenu keyboard commands. |is_rtl| will be true
		/// (1) if the menu is displaying a right-to-left language.
		/// </summary>
		protected internal unsafe virtual void UnhandledOpenSubmenu(CefMenuModel menuModel, bool isRtl)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void UnhandledOpenSubmenuDelegate(cef_menu_model_delegate_t* self, cef_menu_model_t* menu_model, int is_rtl);

		// void (*)(_cef_menu_model_delegate_t* self, _cef_menu_model_t* menu_model, int is_rtl)*
		private static unsafe void UnhandledOpenSubmenuImpl(cef_menu_model_delegate_t* self, cef_menu_model_t* menu_model, int is_rtl)
		{
			var instance = GetInstance((IntPtr)self) as CefMenuModelDelegate;
			if (instance == null || ((ICefMenuModelDelegatePrivate)instance).AvoidUnhandledOpenSubmenu())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)menu_model);
				return;
			}
			instance.UnhandledOpenSubmenu(CefMenuModel.Wrap(CefMenuModel.Create, menu_model), is_rtl != 0);
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefMenuModelDelegatePrivate.AvoidUnhandledCloseSubmenu();

		/// <summary>
		/// Called on unhandled close submenu keyboard commands. |is_rtl| will be true
		/// (1) if the menu is displaying a right-to-left language.
		/// </summary>
		protected internal unsafe virtual void UnhandledCloseSubmenu(CefMenuModel menuModel, bool isRtl)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void UnhandledCloseSubmenuDelegate(cef_menu_model_delegate_t* self, cef_menu_model_t* menu_model, int is_rtl);

		// void (*)(_cef_menu_model_delegate_t* self, _cef_menu_model_t* menu_model, int is_rtl)*
		private static unsafe void UnhandledCloseSubmenuImpl(cef_menu_model_delegate_t* self, cef_menu_model_t* menu_model, int is_rtl)
		{
			var instance = GetInstance((IntPtr)self) as CefMenuModelDelegate;
			if (instance == null || ((ICefMenuModelDelegatePrivate)instance).AvoidUnhandledCloseSubmenu())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)menu_model);
				return;
			}
			instance.UnhandledCloseSubmenu(CefMenuModel.Wrap(CefMenuModel.Create, menu_model), is_rtl != 0);
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefMenuModelDelegatePrivate.AvoidMenuWillShow();

		/// <summary>
		/// The menu is about to show.
		/// </summary>
		protected internal unsafe virtual void MenuWillShow(CefMenuModel menuModel)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void MenuWillShowDelegate(cef_menu_model_delegate_t* self, cef_menu_model_t* menu_model);

		// void (*)(_cef_menu_model_delegate_t* self, _cef_menu_model_t* menu_model)*
		private static unsafe void MenuWillShowImpl(cef_menu_model_delegate_t* self, cef_menu_model_t* menu_model)
		{
			var instance = GetInstance((IntPtr)self) as CefMenuModelDelegate;
			if (instance == null || ((ICefMenuModelDelegatePrivate)instance).AvoidMenuWillShow())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)menu_model);
				return;
			}
			instance.MenuWillShow(CefMenuModel.Wrap(CefMenuModel.Create, menu_model));
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefMenuModelDelegatePrivate.AvoidMenuClosed();

		/// <summary>
		/// The menu has closed.
		/// </summary>
		protected internal unsafe virtual void MenuClosed(CefMenuModel menuModel)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void MenuClosedDelegate(cef_menu_model_delegate_t* self, cef_menu_model_t* menu_model);

		// void (*)(_cef_menu_model_delegate_t* self, _cef_menu_model_t* menu_model)*
		private static unsafe void MenuClosedImpl(cef_menu_model_delegate_t* self, cef_menu_model_t* menu_model)
		{
			var instance = GetInstance((IntPtr)self) as CefMenuModelDelegate;
			if (instance == null || ((ICefMenuModelDelegatePrivate)instance).AvoidMenuClosed())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)menu_model);
				return;
			}
			instance.MenuClosed(CefMenuModel.Wrap(CefMenuModel.Create, menu_model));
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefMenuModelDelegatePrivate.AvoidFormatLabel();

		/// <summary>
		/// Optionally modify a menu item label. Return true (1) if |label| was
		/// modified.
		/// </summary>
		protected internal unsafe virtual bool FormatLabel(CefMenuModel menuModel, ref string label)
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int FormatLabelDelegate(cef_menu_model_delegate_t* self, cef_menu_model_t* menu_model, cef_string_t* label);

		// int (*)(_cef_menu_model_delegate_t* self, _cef_menu_model_t* menu_model, cef_string_t* label)*
		private static unsafe int FormatLabelImpl(cef_menu_model_delegate_t* self, cef_menu_model_t* menu_model, cef_string_t* label)
		{
			var instance = GetInstance((IntPtr)self) as CefMenuModelDelegate;
			if (instance == null || ((ICefMenuModelDelegatePrivate)instance).AvoidFormatLabel())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)menu_model);
				return default;
			}
			string s_label = CefString.Read(label);
			string s_orig_label = s_label;
			int rv = instance.FormatLabel(CefMenuModel.Wrap(CefMenuModel.Create, menu_model), ref s_label) ? 1 : 0;
			if (s_label != s_orig_label)
				CefString.Replace(label, s_label);
			return rv;
		}
	}
}
