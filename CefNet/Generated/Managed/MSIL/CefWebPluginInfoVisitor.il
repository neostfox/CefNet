﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Managed/Types/CefWebPluginInfoVisitor.cs
// --------------------------------------------------------------------------------------------﻿
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
// --------------------------------------------------------------------------------------------

.namespace CefNet
{
	.class public CefWebPluginInfoVisitor
	{

		.method private final hidebysig newslot virtual instance bool CefNet.Internal.ICefWebPluginInfoVisitorPrivate.AvoidVisit()
		{
			.override method instance bool CefNet.Internal.ICefWebPluginInfoVisitorPrivate::AvoidVisit()
			.maxstack 2
			ldarg.0
			ldvirtftn instance bool CefNet.CefWebPluginInfoVisitor::Visit(class CefNet.CefWebPluginInfo, int32, int32)
			ldftn instance bool CefNet.CefWebPluginInfoVisitor::Visit(class CefNet.CefWebPluginInfo, int32, int32)
			ceq
			ret
		}

	}
}
