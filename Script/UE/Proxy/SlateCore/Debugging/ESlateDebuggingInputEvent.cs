﻿using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.ESlateDebuggingInputEvent")]
	public enum ESlateDebuggingInputEvent : long
	{
		MouseMove = 0,
		MouseEnter = 1,
		MouseLeave = 2,
		PreviewMouseButtonDown = 3,
		MouseButtonDown = 4,
		MouseButtonUp = 5,
		MouseButtonDoubleClick = 6,
		MouseWheel = 7,
		TouchStart = 8,
		TouchEnd = 9,
		TouchForceChanged = 10,
		TouchFirstMove = 11,
		TouchMoved = 12,
		DragDetected = 13,
		DragEnter = 14,
		DragLeave = 15,
		DragOver = 16,
		DragDrop = 17,
		DropMessage = 18,
		PreviewKeyDown = 19,
		KeyDown = 20,
		KeyUp = 21,
		KeyChar = 22,
		AnalogInput = 23,
		TouchGesture = 24,
		MotionDetected = 25,
	}
}