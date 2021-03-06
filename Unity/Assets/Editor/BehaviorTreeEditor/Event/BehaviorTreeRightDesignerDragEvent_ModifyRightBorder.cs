﻿using Model;

namespace MyEditor
{
	[Event(EventIdType.BehaviorTreeRightDesignerDrag)]
	public class BehaviorTreeRightDesignerDragEvent_ModifyRightBorder: IEvent<float>
	{
		public void Run(float deltaX)
		{
			BehaviorDesignerWindow.Instance.onDraggingRightDesigner(deltaX);
		}
	}
}