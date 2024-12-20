﻿using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EFBXExpectedResultPreset")]
	public enum EFBXExpectedResultPreset : byte
	{
		Error_Number = 0,
		Warning_Number = 1,
		Created_Staticmesh_Number = 2,
		Created_Skeletalmesh_Number = 3,
		Materials_Created_Number = 4,
		Material_Slot_Imported_Name = 5,
		Vertex_Number = 6,
		Lod_Number = 7,
		Vertex_Number_Lod = 8,
		Mesh_Materials_Number = 9,
		Mesh_LOD_Section_Number = 10,
		Mesh_LOD_Section_Vertex_Number = 11,
		Mesh_LOD_Section_Triangle_Number = 12,
		Mesh_LOD_Section_Material_Name = 13,
		Mesh_LOD_Section_Material_Index = 14,
		Mesh_LOD_Section_Material_Imported_Name = 15,
		Mesh_LOD_Vertex_Position = 16,
		Mesh_LOD_Vertex_Normal = 17,
		LOD_UV_Channel_Number = 18,
		Bone_Number = 19,
		Bone_Position = 20,
		Animation_Frame_Number = 21,
		Animation_Length = 22,
		Animation_CustomCurve_KeyValue = 23,
		Animation_CustomCurve_KeyArriveTangent = 24,
		Animation_CustomCurve_KeyLeaveTangent = 25,
		Skin_By_Bone_Vertex_Number = 26,
		Animation_CustomCurve_KeyArriveTangentWeight = 27,
		Animation_CustomCurve_KeyLeaveTangentWeight = 28,
	}
}