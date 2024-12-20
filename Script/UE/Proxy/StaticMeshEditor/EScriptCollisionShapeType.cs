﻿using Script.CoreUObject;

namespace Script.StaticMeshEditor
{
	[PathName("/Script/StaticMeshEditor.EScriptCollisionShapeType")]
	public enum EScriptCollisionShapeType : byte
	{
		Box = 0,
		Sphere = 1,
		Capsule = 2,
		NDOP10_X = 3,
		NDOP10_Y = 4,
		NDOP10_Z = 5,
		NDOP18 = 6,
		NDOP26 = 7,
	}
}