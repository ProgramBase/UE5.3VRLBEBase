﻿using Script.CoreUObject;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.EEditMeshPolygonsToolActions")]
	public enum EEditMeshPolygonsToolActions : long
	{
		NoAction = 0,
		AcceptCurrent = 1,
		CancelCurrent = 2,
		Extrude = 3,
		PushPull = 4,
		Offset = 5,
		Inset = 6,
		Outset = 7,
		BevelFaces = 8,
		InsertEdge = 9,
		InsertEdgeLoop = 10,
		Complete = 11,
		PlaneCut = 12,
		Merge = 13,
		Delete = 14,
		CutFaces = 15,
		RecalculateNormals = 16,
		FlipNormals = 17,
		Retriangulate = 18,
		Decompose = 19,
		Disconnect = 20,
		Duplicate = 21,
		CollapseEdge = 22,
		WeldEdges = 23,
		StraightenEdge = 24,
		FillHole = 25,
		BridgeEdges = 26,
		BevelEdges = 27,
		SimplifyAlongEdges = 28,
		PlanarProjectionUV = 29,
		SimplifyByGroups = 30,
		RegenerateExtraCorners = 31,
		PokeSingleFace = 32,
		SplitSingleEdge = 33,
		FlipSingleEdge = 34,
		CollapseSingleEdge = 35,
		BevelAuto = 36,
	}
}