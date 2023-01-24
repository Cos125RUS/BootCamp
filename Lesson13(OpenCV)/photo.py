import cv2
#
# img = cv2.imread('test.jpg')
# print(img.shape)
# img = cv2.resize(img, (500, 500))
# print(img.shape)
#
# cv2.imshow('Result', img)
#
# cv2.waitKey(0)

face_cascades = cv2.CascadeClassifier("haarcascade_frontalface_default.xml")

img = cv2.imread('face.jpg')
img_gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

faces = face_cascades.detectMultiScale(img_gray)

for (x, y, w, h) in faces:
    cv2.rectangle(img, (x, y), (x + w, y + h), (0, 255, 255), 2)

img = cv2.resize(img, (400, 500))
cv2.imshow('Result', img)
cv2.waitKey(0)
