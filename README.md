# 날씨 정보 조회 프로그램 (GitFlow Hands-on Lab)

OpenWeatherMap API를 사용하여 도시별 날씨 정보를 조회하는 C# 콘솔 애플리케이션입니다.

## 프로젝트 구조

```
/workspace/
  ├── Models/                  # 데이터 모델
  │   ├── MainData.cs         # 주요 날씨 데이터
  │   ├── WeatherData.cs      # 날씨 정보 DTO
  │   ├── WeatherInfo.cs      # 날씨 상세 정보
  │   ├── WeatherResponse.cs  # API 응답 모델
  │   └── WindInfo.cs         # 바람 정보
  ├── Services/               # 비즈니스 로직
  │   ├── WeatherConfig.cs    # 설정 관리
  │   ├── WeatherService.cs   # 날씨 API 서비스
  │   └── WeatherDisplay.cs   # 콘솔 출력 서비스
  └── Program.cs              # 메인 엔트리 포인트
```

## 주요 기능

- ✅ OpenWeatherMap API를 통한 실시간 날씨 정보 조회
- ✅ 사용자 입력을 통한 도시별 날씨 검색
- ✅ 온도, 습도, 풍속, 날씨 상태 표시
- ✅ 환경 변수를 통한 API 키 관리
- ✅ 깔끔한 객체지향 설계 (서비스 패턴)

## 설치 및 실행

### 1. API 키 설정

OpenWeatherMap API 키가 필요합니다:

1. [OpenWeatherMap](https://openweathermap.org/api)에서 무료 API 키 발급
2. 환경 변수 설정:

```bash
# Windows
set OPENWEATHER_API_KEY=your_api_key

# Linux/Mac
export OPENWEATHER_API_KEY=your_api_key
```

### 2. 프로젝트 빌드 및 실행

```bash
dotnet build
dotnet run
```

## 사용 방법

프로그램을 실행하면 도시 이름을 입력하라는 메시지가 나타납니다:

```
날씨 정보 조회 프로그램
도시를 입력하세요 (기본값: Seoul):
```

도시 이름을 입력하면 해당 도시의 날씨 정보가 표시됩니다:

```
=== 날씨 정보 ===
도시: Seoul
온도: 15.5°C
상태: 맑음
습도: 60%
풍속: 3.5 m/s
================
```

## 기술 스택

- C# 12 / .NET 8.0
- System.Text.Json (JSON 직렬화)
- HttpClient (HTTP 통신)
- OpenWeatherMap API

## 아키텍처 개선 사항

이 프로젝트는 다음과 같은 리팩토링을 통해 개선되었습니다:

1. **관심사의 분리**: 
   - Models: 데이터 구조 정의
   - Services: 비즈니스 로직 및 API 통신
   - Program: 애플리케이션 진입점

2. **설정 관리**:
   - WeatherConfig 클래스로 API 설정 중앙화

3. **서비스 패턴**:
   - WeatherService: API 호출 및 데이터 변환
   - WeatherDisplay: UI/출력 로직

4. **리소스 관리**:
   - IDisposable 패턴을 통한 HttpClient 정리

5. **네임스페이스 구조**:
   - GitFlowHandsOnLab.Models
   - GitFlowHandsOnLab.Services

## 라이선스

이 프로젝트는 교육 목적으로 작성되었습니다.