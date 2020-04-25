﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_v8interceptor_t.cs
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
	/// Structure that should be implemented to handle V8 interceptor calls. The
	/// functions of this structure will be called on the thread associated with the
	/// V8 interceptor. Interceptor&apos;s named property handlers (with first argument of
	/// type CefString) are called when object is indexed by string. Indexed property
	/// handlers (with first argument of type int) are called when object is indexed
	/// by integer.
	/// </summary>
	/// <remarks>
	/// Role: Handler
	/// </remarks>
	public unsafe partial class CefV8Interceptor : CefBaseRefCounted<cef_v8interceptor_t>, ICefV8InterceptorPrivate
	{
		private static readonly GetByNameDelegate fnGetByName = GetByNameImpl;

		private static readonly GetByIndexDelegate fnGetByIndex = GetByIndexImpl;

		private static readonly SetByNameDelegate fnSetByName = SetByNameImpl;

		private static readonly SetByIndexDelegate fnSetByIndex = SetByIndexImpl;

		internal static unsafe CefV8Interceptor Create(IntPtr instance)
		{
			return new CefV8Interceptor((cef_v8interceptor_t*)instance);
		}

		public CefV8Interceptor()
		{
			cef_v8interceptor_t* self = this.NativeInstance;
			self->get_byname = (void*)Marshal.GetFunctionPointerForDelegate(fnGetByName);
			self->get_byindex = (void*)Marshal.GetFunctionPointerForDelegate(fnGetByIndex);
			self->set_byname = (void*)Marshal.GetFunctionPointerForDelegate(fnSetByName);
			self->set_byindex = (void*)Marshal.GetFunctionPointerForDelegate(fnSetByIndex);
		}

		public CefV8Interceptor(cef_v8interceptor_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefV8InterceptorPrivate.AvoidGetByName();

		/// <summary>
		/// Handle retrieval of the interceptor value identified by |name|. |object| is
		/// the receiver (&apos;this&apos; object) of the interceptor. If retrieval succeeds, set
		/// |retval| to the return value. If the requested value does not exist, don&apos;t
		/// set either |retval| or |exception|. If retrieval fails, set |exception| to
		/// the exception that will be thrown. If the property has an associated
		/// accessor, it will be called only if you don&apos;t set |retval|. Return true (1)
		/// if interceptor retrieval was handled, false (0) otherwise.
		/// </summary>
		protected internal unsafe virtual bool GetByName(string name, CefV8Value @object, ref CefV8Value retval, ref string exception)
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int GetByNameDelegate(cef_v8interceptor_t* self, cef_string_t* name, cef_v8value_t* @object, cef_v8value_t** retval, cef_string_t* exception);

		// int (*)(_cef_v8interceptor_t* self, const cef_string_t* name, _cef_v8value_t* object, _cef_v8value_t** retval, cef_string_t* exception)*
		private static unsafe int GetByNameImpl(cef_v8interceptor_t* self, cef_string_t* name, cef_v8value_t* @object, cef_v8value_t** retval, cef_string_t* exception)
		{
			var instance = GetInstance((IntPtr)self) as CefV8Interceptor;
			if (instance == null || ((ICefV8InterceptorPrivate)instance).AvoidGetByName())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)@object);
				return default;
			}
			CefV8Value obj_retval = CefV8Value.Wrap(CefV8Value.Create, *retval);
			string s_exception = CefString.Read(exception);
			string s_orig_exception = s_exception;
			int rv = instance.GetByName(CefString.Read(name), CefV8Value.Wrap(CefV8Value.Create, @object), ref obj_retval, ref s_exception) ? 1 : 0;
			*retval = (obj_retval != null) ? obj_retval.GetNativeInstance() : null;
			if (s_exception != s_orig_exception)
				CefString.Replace(exception, s_exception);
			return rv;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefV8InterceptorPrivate.AvoidGetByIndex();

		/// <summary>
		/// Handle retrieval of the interceptor value identified by |index|. |object|
		/// is the receiver (&apos;this&apos; object) of the interceptor. If retrieval succeeds,
		/// set |retval| to the return value. If the requested value does not exist,
		/// don&apos;t set either |retval| or |exception|. If retrieval fails, set
		/// |exception| to the exception that will be thrown. Return true (1) if
		/// interceptor retrieval was handled, false (0) otherwise.
		/// </summary>
		protected internal unsafe virtual bool GetByIndex(int index, CefV8Value @object, ref CefV8Value retval, ref string exception)
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int GetByIndexDelegate(cef_v8interceptor_t* self, int index, cef_v8value_t* @object, cef_v8value_t** retval, cef_string_t* exception);

		// int (*)(_cef_v8interceptor_t* self, int index, _cef_v8value_t* object, _cef_v8value_t** retval, cef_string_t* exception)*
		private static unsafe int GetByIndexImpl(cef_v8interceptor_t* self, int index, cef_v8value_t* @object, cef_v8value_t** retval, cef_string_t* exception)
		{
			var instance = GetInstance((IntPtr)self) as CefV8Interceptor;
			if (instance == null || ((ICefV8InterceptorPrivate)instance).AvoidGetByIndex())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)@object);
				return default;
			}
			CefV8Value obj_retval = CefV8Value.Wrap(CefV8Value.Create, *retval);
			string s_exception = CefString.Read(exception);
			string s_orig_exception = s_exception;
			int rv = instance.GetByIndex(index, CefV8Value.Wrap(CefV8Value.Create, @object), ref obj_retval, ref s_exception) ? 1 : 0;
			*retval = (obj_retval != null) ? obj_retval.GetNativeInstance() : null;
			if (s_exception != s_orig_exception)
				CefString.Replace(exception, s_exception);
			return rv;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefV8InterceptorPrivate.AvoidSetByName();

		/// <summary>
		/// Handle assignment of the interceptor value identified by |name|. |object|
		/// is the receiver (&apos;this&apos; object) of the interceptor. |value| is the new
		/// value being assigned to the interceptor. If assignment fails, set
		/// |exception| to the exception that will be thrown. This setter will always
		/// be called, even when the property has an associated accessor. Return true
		/// (1) if interceptor assignment was handled, false (0) otherwise.
		/// </summary>
		protected internal unsafe virtual bool SetByName(string name, CefV8Value @object, CefV8Value value, ref string exception)
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int SetByNameDelegate(cef_v8interceptor_t* self, cef_string_t* name, cef_v8value_t* @object, cef_v8value_t* value, cef_string_t* exception);

		// int (*)(_cef_v8interceptor_t* self, const cef_string_t* name, _cef_v8value_t* object, _cef_v8value_t* value, cef_string_t* exception)*
		private static unsafe int SetByNameImpl(cef_v8interceptor_t* self, cef_string_t* name, cef_v8value_t* @object, cef_v8value_t* value, cef_string_t* exception)
		{
			var instance = GetInstance((IntPtr)self) as CefV8Interceptor;
			if (instance == null || ((ICefV8InterceptorPrivate)instance).AvoidSetByName())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)@object);
				ReleaseIfNonNull((cef_base_ref_counted_t*)value);
				return default;
			}
			string s_exception = CefString.Read(exception);
			string s_orig_exception = s_exception;
			int rv = instance.SetByName(CefString.Read(name), CefV8Value.Wrap(CefV8Value.Create, @object), CefV8Value.Wrap(CefV8Value.Create, value), ref s_exception) ? 1 : 0;
			if (s_exception != s_orig_exception)
				CefString.Replace(exception, s_exception);
			return rv;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefV8InterceptorPrivate.AvoidSetByIndex();

		/// <summary>
		/// Handle assignment of the interceptor value identified by |index|. |object|
		/// is the receiver (&apos;this&apos; object) of the interceptor. |value| is the new
		/// value being assigned to the interceptor. If assignment fails, set
		/// |exception| to the exception that will be thrown. Return true (1) if
		/// interceptor assignment was handled, false (0) otherwise.
		/// </summary>
		protected internal unsafe virtual bool SetByIndex(int index, CefV8Value @object, CefV8Value value, ref string exception)
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int SetByIndexDelegate(cef_v8interceptor_t* self, int index, cef_v8value_t* @object, cef_v8value_t* value, cef_string_t* exception);

		// int (*)(_cef_v8interceptor_t* self, int index, _cef_v8value_t* object, _cef_v8value_t* value, cef_string_t* exception)*
		private static unsafe int SetByIndexImpl(cef_v8interceptor_t* self, int index, cef_v8value_t* @object, cef_v8value_t* value, cef_string_t* exception)
		{
			var instance = GetInstance((IntPtr)self) as CefV8Interceptor;
			if (instance == null || ((ICefV8InterceptorPrivate)instance).AvoidSetByIndex())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)@object);
				ReleaseIfNonNull((cef_base_ref_counted_t*)value);
				return default;
			}
			string s_exception = CefString.Read(exception);
			string s_orig_exception = s_exception;
			int rv = instance.SetByIndex(index, CefV8Value.Wrap(CefV8Value.Create, @object), CefV8Value.Wrap(CefV8Value.Create, value), ref s_exception) ? 1 : 0;
			if (s_exception != s_orig_exception)
				CefString.Replace(exception, s_exception);
			return rv;
		}
	}
}
