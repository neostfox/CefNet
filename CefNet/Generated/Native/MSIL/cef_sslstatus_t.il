﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_ssl_status_capi.h
// --------------------------------------------------------------------------------------------﻿
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
// --------------------------------------------------------------------------------------------


.namespace CefNet.CApi
{
	.class public cef_sslstatus_t
	{
		// int (*)(_cef_sslstatus_t* self)*
		.method public hidebysig int32 IsSecureConnection()
		{
			.maxstack 2
			ldarg.0
			ldarg.0
			ldfld void* CefNet.CApi.cef_sslstatus_t::is_secure_connection
			calli explicit unmanaged
#ifdef WINDOWS
				stdcall
#else
				cdecl
#endif
				int32(valuetype CefNet.CApi.cef_sslstatus_t*)
			ret
		}

		// cef_cert_status_t (*)(_cef_sslstatus_t* self)*
		.method public hidebysig valuetype CefNet.CefCertStatus GetCertStatus()
		{
			.maxstack 2
			ldarg.0
			ldarg.0
			ldfld void* CefNet.CApi.cef_sslstatus_t::get_cert_status
			calli explicit unmanaged
#ifdef WINDOWS
				stdcall
#else
				cdecl
#endif
				valuetype CefNet.CefCertStatus(valuetype CefNet.CApi.cef_sslstatus_t*)
			ret
		}

		// cef_ssl_version_t (*)(_cef_sslstatus_t* self)*
		.method public hidebysig valuetype CefNet.CefSSLVersion GetSslversion()
		{
			.maxstack 2
			ldarg.0
			ldarg.0
			ldfld void* CefNet.CApi.cef_sslstatus_t::get_sslversion
			calli explicit unmanaged
#ifdef WINDOWS
				stdcall
#else
				cdecl
#endif
				valuetype CefNet.CefSSLVersion(valuetype CefNet.CApi.cef_sslstatus_t*)
			ret
		}

		// cef_ssl_content_status_t (*)(_cef_sslstatus_t* self)*
		.method public hidebysig valuetype CefNet.CefSSLContentStatus GetContentStatus()
		{
			.maxstack 2
			ldarg.0
			ldarg.0
			ldfld void* CefNet.CApi.cef_sslstatus_t::get_content_status
			calli explicit unmanaged
#ifdef WINDOWS
				stdcall
#else
				cdecl
#endif
				valuetype CefNet.CefSSLContentStatus(valuetype CefNet.CApi.cef_sslstatus_t*)
			ret
		}

		// _cef_x509certificate_t* (*)(_cef_sslstatus_t* self)*
		.method public hidebysig valuetype CefNet.CApi.cef_x509certificate_t* GetX509certificate()
		{
			.maxstack 2
			ldarg.0
			ldarg.0
			ldfld void* CefNet.CApi.cef_sslstatus_t::get_x509certificate
			calli explicit unmanaged
#ifdef WINDOWS
				stdcall
#else
				cdecl
#endif
				valuetype CefNet.CApi.cef_x509certificate_t*(valuetype CefNet.CApi.cef_sslstatus_t*)
			ret
		}
	}
}

