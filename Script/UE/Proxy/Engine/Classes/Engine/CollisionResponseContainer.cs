using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CollisionResponseContainer")]
	public partial class FCollisionResponseContainer : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.CollisionResponseContainer");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCollisionResponseContainer() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCollisionResponseContainer() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCollisionResponseContainer A, FCollisionResponseContainer B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCollisionResponseContainer A, FCollisionResponseContainer B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCollisionResponseContainer;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ECollisionResponse WorldStatic
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WorldStatic, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WorldStatic, __InBuffer);
				}
			}
		}

		public ECollisionResponse WorldDynamic
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WorldDynamic, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WorldDynamic, __InBuffer);
				}
			}
		}

		public ECollisionResponse Pawn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Pawn, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Pawn, __InBuffer);
				}
			}
		}

		public ECollisionResponse Visibility
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Visibility, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Visibility, __InBuffer);
				}
			}
		}

		public ECollisionResponse Camera
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Camera, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Camera, __InBuffer);
				}
			}
		}

		public ECollisionResponse PhysicsBody
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PhysicsBody, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PhysicsBody, __InBuffer);
				}
			}
		}

		public ECollisionResponse Vehicle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Vehicle, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Vehicle, __InBuffer);
				}
			}
		}

		public ECollisionResponse Destructible
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Destructible, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Destructible, __InBuffer);
				}
			}
		}

		public ECollisionResponse EngineTraceChannel1
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EngineTraceChannel1, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EngineTraceChannel1, __InBuffer);
				}
			}
		}

		public ECollisionResponse EngineTraceChannel2
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EngineTraceChannel2, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EngineTraceChannel2, __InBuffer);
				}
			}
		}

		public ECollisionResponse EngineTraceChannel3
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EngineTraceChannel3, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EngineTraceChannel3, __InBuffer);
				}
			}
		}

		public ECollisionResponse EngineTraceChannel4
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EngineTraceChannel4, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EngineTraceChannel4, __InBuffer);
				}
			}
		}

		public ECollisionResponse EngineTraceChannel5
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EngineTraceChannel5, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EngineTraceChannel5, __InBuffer);
				}
			}
		}

		public ECollisionResponse EngineTraceChannel6
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EngineTraceChannel6, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EngineTraceChannel6, __InBuffer);
				}
			}
		}

		public ECollisionResponse GameTraceChannel1
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel1, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel1, __InBuffer);
				}
			}
		}

		public ECollisionResponse GameTraceChannel2
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel2, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel2, __InBuffer);
				}
			}
		}

		public ECollisionResponse GameTraceChannel3
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel3, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel3, __InBuffer);
				}
			}
		}

		public ECollisionResponse GameTraceChannel4
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel4, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel4, __InBuffer);
				}
			}
		}

		public ECollisionResponse GameTraceChannel5
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel5, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel5, __InBuffer);
				}
			}
		}

		public ECollisionResponse GameTraceChannel6
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel6, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel6, __InBuffer);
				}
			}
		}

		public ECollisionResponse GameTraceChannel7
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel7, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel7, __InBuffer);
				}
			}
		}

		public ECollisionResponse GameTraceChannel8
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel8, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel8, __InBuffer);
				}
			}
		}

		public ECollisionResponse GameTraceChannel9
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel9, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel9, __InBuffer);
				}
			}
		}

		public ECollisionResponse GameTraceChannel10
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel10, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel10, __InBuffer);
				}
			}
		}

		public ECollisionResponse GameTraceChannel11
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel11, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel11, __InBuffer);
				}
			}
		}

		public ECollisionResponse GameTraceChannel12
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel12, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel12, __InBuffer);
				}
			}
		}

		public ECollisionResponse GameTraceChannel13
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel13, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel13, __InBuffer);
				}
			}
		}

		public ECollisionResponse GameTraceChannel14
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel14, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel14, __InBuffer);
				}
			}
		}

		public ECollisionResponse GameTraceChannel15
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel15, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel15, __InBuffer);
				}
			}
		}

		public ECollisionResponse GameTraceChannel16
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel16, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel16, __InBuffer);
				}
			}
		}

		public ECollisionResponse GameTraceChannel17
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel17, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel17, __InBuffer);
				}
			}
		}

		public ECollisionResponse GameTraceChannel18
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel18, __ReturnBuffer);

					return *(ECollisionResponse*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GameTraceChannel18, __InBuffer);
				}
			}
		}

		private static uint __WorldStatic = 0;

		private static uint __WorldDynamic = 0;

		private static uint __Pawn = 0;

		private static uint __Visibility = 0;

		private static uint __Camera = 0;

		private static uint __PhysicsBody = 0;

		private static uint __Vehicle = 0;

		private static uint __Destructible = 0;

		private static uint __EngineTraceChannel1 = 0;

		private static uint __EngineTraceChannel2 = 0;

		private static uint __EngineTraceChannel3 = 0;

		private static uint __EngineTraceChannel4 = 0;

		private static uint __EngineTraceChannel5 = 0;

		private static uint __EngineTraceChannel6 = 0;

		private static uint __GameTraceChannel1 = 0;

		private static uint __GameTraceChannel2 = 0;

		private static uint __GameTraceChannel3 = 0;

		private static uint __GameTraceChannel4 = 0;

		private static uint __GameTraceChannel5 = 0;

		private static uint __GameTraceChannel6 = 0;

		private static uint __GameTraceChannel7 = 0;

		private static uint __GameTraceChannel8 = 0;

		private static uint __GameTraceChannel9 = 0;

		private static uint __GameTraceChannel10 = 0;

		private static uint __GameTraceChannel11 = 0;

		private static uint __GameTraceChannel12 = 0;

		private static uint __GameTraceChannel13 = 0;

		private static uint __GameTraceChannel14 = 0;

		private static uint __GameTraceChannel15 = 0;

		private static uint __GameTraceChannel16 = 0;

		private static uint __GameTraceChannel17 = 0;

		private static uint __GameTraceChannel18 = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}