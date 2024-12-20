﻿using Script.CoreUObject;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.EClusterSizeMethodEnum")]
	public enum EClusterSizeMethodEnum : byte
	{
		Dataflow_ClusterSizeMethod_ByNumber = 0,
		Dataflow_ClusterSizeMethod_ByFractionOfInput = 1,
		Dataflow_ClusterSizeMethod_BySize = 2,
		Dataflow_ClusterSizeMethod_ByGrid = 3,
		Dataflow_Max = 4,
	}
}