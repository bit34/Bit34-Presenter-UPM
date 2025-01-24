using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;


namespace Com.Bit34Games.Presenter.Unity
{
    public class PresenterUnityHelpers
    {
        //  METHODS
        public static void SlideContainerFromRight(RectTransform container, float duration, float delay=0, TweenCallback onComplete=null)
        {
            Vector2 position       = container.anchoredPosition;
            Vector2 slidedPosition = new Vector2(container.anchoredPosition.x + container.rect.width, container.anchoredPosition.y);
            container.anchoredPosition = slidedPosition;
            Tween tween = container.DOAnchorPos(position, duration);
            if (delay > 0)
            {
                tween.SetDelay(delay);
            }
            if (onComplete != null)
            {
                tween.OnComplete(onComplete);
            }
        }

        public static void SlideContainerFromLeft(RectTransform container, float duration, float delay=0, TweenCallback onComplete=null)
        {
            Vector2 position       = container.anchoredPosition;
            Vector2 slidedPosition = new Vector2(container.anchoredPosition.x - container.rect.width, container.anchoredPosition.y);
            container.anchoredPosition = slidedPosition;
            Tween tween = container.DOAnchorPos(position, duration);
            if (delay > 0)
            {
                tween.SetDelay(delay);
            }
            if (onComplete != null)
            {
                tween.OnComplete(onComplete);
            }
        }

        public static void SlideContainerToRight(RectTransform container, float duration, float delay=0, TweenCallback onComplete=null)
        {
            Vector2 slidedPosition = new Vector2(container.anchoredPosition.x + container.rect.width, container.anchoredPosition.y);
            Tween   tween          = container.DOAnchorPos(slidedPosition, duration);
            if (delay > 0)
            {
                tween.SetDelay(delay);
            }
            if (onComplete != null)
            {
                tween.OnComplete(onComplete);
            }
        }

        public static void SlideContainerToLeft(RectTransform container, float duration, float delay=0, TweenCallback onComplete=null)
        {
            Vector2 slidedPosition = new Vector2(container.anchoredPosition.x - container.rect.width, container.anchoredPosition.y);
            Tween   tween          = container.DOAnchorPos(slidedPosition, duration);
            if (delay > 0)
            {
                tween.SetDelay(delay);
            }
            if (onComplete != null)
            {
                tween.OnComplete(onComplete);
            }
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

        public static void FadeAllGraphicsWithTween(RectTransform container, float alpha, float duration, float delay=0, TweenCallback onComplete=null)
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
                sequence.Insert(0, graphics[i].DOFade(alpha, duration)
                                              .SetEase(Ease.OutCubic));
            }
        }

        public static void KillAllGraphicsTweens(GameObject gameObject)
        {
            Graphic[] graphics = gameObject.GetComponentsInChildren<Graphic>();
            for (int i = 0; i < graphics.Length; i++)
            {
                graphics[i].DOKill();
            }
        }
    }
}
