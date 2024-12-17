using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BranchingPointMarker")]
	public partial class FBranchingPointMarker : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.BranchingPointMarker");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBranchingPointMarker() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBranchingPointMarker() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBranchingPointMarker A, FBranchingPointMarker B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBranchingPointMarker A, FBranchingPointMarker B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBranchingPointMarker;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int NotifyIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NotifyIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NotifyIndex, __InBuffer);
				}
			}
		}

		public float TriggerTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TriggerTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TriggerTime, __InBuffer);
				}
			}
		}

		public EAnimNotifyEventType NotifyEventType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NotifyEventType, __ReturnBuffer);

					return *(EAnimNotifyEventType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NotifyEventType, __InBuffer);
				}
			}
		}

		private static uint __NotifyIndex = 0;

		private static uint __TriggerTime = 0;

		private static uint __NotifyEventType = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}