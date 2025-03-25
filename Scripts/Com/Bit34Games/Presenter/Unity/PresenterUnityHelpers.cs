using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;


namespace Com.Bit34Games.Presenter.Unity
{
    public class PresenterUnityHelpers
    {
        //  METHODS

        public static void SlideContainer(RectTransform container, Vector2 startPosition, Vector2 endPosition, float duration, float delay=0, TweenCallback onComplete=null)
        {
            container.anchoredPosition = startPosition;
            Tween tween = container.DOAnchorPos(endPosition, duration);
            if (delay > 0)
            {
                tween.SetDelay(delay);
            }
            if (onComplete != null)
            {
                tween.OnComplete(onComplete);
            }
        }

        public static void SlideContainerFromRight(RectTransform container, float duration, float delay=0, TweenCallback onComplete=null)
        {
            Vector2 position       = container.anchoredPosition;
            Vector2 slidedPosition = new Vector2(container.anchoredPosition.x + container.rect.width, container.anchoredPosition.y);
            SlideContainer(container, slidedPosition, position, duration, delay, onComplete);
        }

        public static void SlideContainerFromLeft(RectTransform container, float duration, float delay=0, TweenCallback onComplete=null)
        {
            Vector2 position       = container.anchoredPosition;
            Vector2 slidedPosition = new Vector2(container.anchoredPosition.x - container.rect.width, container.anchoredPosition.y);
            SlideContainer(container, slidedPosition, position, duration, delay, onComplete);
        }

        public static void SlideContainerFromBottom(RectTransform container, float duration, float delay=0, TweenCallback onComplete=null)
        {
            Vector2 position       = container.anchoredPosition;
            Vector2 slidedPosition = new Vector2(container.anchoredPosition.x, container.anchoredPosition.y - container.rect.height);
            SlideContainer(container, slidedPosition, position, duration, delay, onComplete);
        }

        public static void SlideContainerToRight(RectTransform container, float duration, float delay=0, TweenCallback onComplete=null)
        {
            Vector2 position       = container.anchoredPosition;
            Vector2 slidedPosition = new Vector2(container.anchoredPosition.x + container.rect.width, container.anchoredPosition.y);
            SlideContainer(container, position, slidedPosition, duration, delay, onComplete);
        }

        public static void SlideContainerToLeft(RectTransform container, float duration, float delay=0, TweenCallback onComplete=null)
        {
            Vector2 position       = container.anchoredPosition;
            Vector2 slidedPosition = new Vector2(container.anchoredPosition.x - container.rect.width, container.anchoredPosition.y);
            SlideContainer(container, position, slidedPosition, duration, delay, onComplete);
        }

        public static void SlideContainerToBottom(RectTransform container, float duration, float delay=0, TweenCallback onComplete=null)
        {
            Vector2 position       = container.anchoredPosition;
            Vector2 slidedPosition = new Vector2(container.anchoredPosition.x, container.anchoredPosition.y - container.rect.height);
            SlideContainer(container, position, slidedPosition, duration, delay, onComplete);
        }

        public static void FadeAllGraphicsInstantly(RectTransform container, float alpha)
        {
            Graphic[] graphics = container.gameObject.GetComponentsInChildren<Graphic>();
            for (int i = 0; i < graphics.Length; i++)
            {
                graphics[i].color = new Color(graphics[i].color.r,
                                              graphics[i].color.g,
                                              graphics[i].color.b,
                                              alpha);
            }
        }

        public static void FadeAllGraphicsWithTween(RectTransform container, float alpha, float duration, float delay=0, bool from=false, TweenCallback onComplete=null)
        {
            Sequence sequence = DOTween.Sequence();
            if (delay > 0)
            {
                sequence.SetDelay(delay);
            }
            if (onComplete != null)
            {
                sequence.OnComplete(onComplete);
            }

            Graphic[] graphics = container.gameObject.GetComponentsInChildren<Graphic>();
            for (int i = 0; i < graphics.Length; i++)
            {
                if (from)
                {
                    sequence.Insert(0, graphics[i].DOFade(alpha, duration)
                                                  .SetEase(Ease.OutCubic)
                                                  .From());
                }
                else
                {
                    sequence.Insert(0, graphics[i].DOFade(alpha, duration)
                                                .SetEase(Ease.OutCubic));
                }
            }
        }

        public static void KillAllGraphicsTweens(RectTransform container)
        {
            Graphic[] graphics = container.gameObject.GetComponentsInChildren<Graphic>();
            for (int i = 0; i < graphics.Length; i++)
            {
                graphics[i].DOKill();
            }
        }
    }
}
