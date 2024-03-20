# Form_Web
* 용량 관계로 CefSharp 패키지를 제외하고 업로드합니다
* 따라서 해당 프로젝트를 실행하기 위해서 Nuget으로 CefSharp를 설치해야합니다
* 설치해야하는 패키지의 버전은 사진과 같습니다
 ![image](https://github.com/hihotz/Form_Web/assets/74196405/f0eeb436-c2a6-4113-a625-2ecdfabcffaf)

winform에 cefsharp을 사용한 브라우저입니다

Form_Web 프로젝트는 혼합 프로그래밍을 공부하기 위한 프로젝트로, Motion 프로젝트의 일부입니다

Form_Web 프로젝트는 단독으로 사용시 cefsharp을 사용한 브라우저로 사용이 가능합니다

# 프로그램 동작사진
![image](https://github.com/hihotz/Form_Web/assets/74196405/dc8b18b9-7cc7-44d6-81d1-7d0568b249c7)
![image](https://github.com/hihotz/Form_Web/assets/74196405/5afc5e65-4667-4a25-95b0-529e892b62c4)
![image](https://github.com/hihotz/Form_Web/assets/74196405/aa81f0bf-ca64-4af3-82fa-6ea4ffba5dc0)

# 프로그램 전체 구성도
![image](https://github.com/hihotz/Form_Web/assets/74196405/11dbe3dd-835f-44a0-84e6-3c82eda703b0)

* index.html에는 머신러닝을 통한 동작감지를 실행합니다
* c++ 언어로 MotionDll.dll을 생성하였으며, 간단한 연산작업을 처리합니다
  상단의 총 동작 횟수를 클릭하여 전달받은 값을 출력합니다
  
# 주요기능
실제 프로그램은 웹으로 사용이 가능합니다

파일찾기 버튼으로 컴퓨터에 있는 파일을 불러올 수 있습니다
